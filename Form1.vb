Imports System.Runtime.InteropServices
Imports System.Threading.Tasks
Public Class Form1
    ' 引入 Windows API 函数
    <DllImport("user32.dll", SetLastError:=True)>
    Private Shared Function RegisterHotKey(ByVal hwnd As IntPtr, ByVal id As Integer, ByVal fsModifiers As UInteger, ByVal vk As UInteger) As Boolean
    End Function

    <DllImport("user32.dll", SetLastError:=True)>
    Private Shared Function UnregisterHotKey(ByVal hwnd As IntPtr, ByVal id As Integer) As Boolean
    End Function

    <DllImport("user32.dll", SetLastError:=True)>
    Private Shared Function SendInput(ByVal nInputs As UInteger, ByVal pInputs() As INPUT, ByVal cbSize As Integer) As UInteger
    End Function

    <DllImport("user32.dll", SetLastError:=True)>
    Private Shared Function SetCursorPos(ByVal x As Integer, ByVal y As Integer) As Boolean
    End Function

    <DllImport("user32.dll", SetLastError:=True)>
    Private Shared Sub mouse_event(ByVal dwFlags As UInteger, ByVal dx As UInteger, ByVal dy As UInteger, ByVal dwData As UInteger, ByVal dwExtraInfo As IntPtr)
    End Sub

    <DllImport("user32.dll")>
    Private Shared Function GetCursorPos(ByRef lpPoint As Point) As Boolean
    End Function
    ' 定义结构体
    <StructLayout(LayoutKind.Sequential)>
    Private Structure INPUT
        Public type As Integer
        Public mkhi As MOUSEKEYBDHARDWAREINPUT
    End Structure

    <StructLayout(LayoutKind.Explicit)>
    Private Structure MOUSEKEYBDHARDWAREINPUT
        <FieldOffset(0)> Public mi As MOUSEINPUT
        <FieldOffset(0)> Public ki As KEYBDINPUT
        <FieldOffset(0)> Public hi As HARDWAREINPUT
    End Structure

    <StructLayout(LayoutKind.Sequential)>
    Private Structure MOUSEINPUT
        Public dx As Integer
        Public dy As Integer
        Public mouseData As UInteger
        Public dwFlags As UInteger
        Public time As UInteger
        Public dwExtraInfo As IntPtr
    End Structure

    <StructLayout(LayoutKind.Sequential)>
    Private Structure KEYBDINPUT
        Public wVk As UShort
        Public wScan As UShort
        Public dwFlags As UInteger
        Public time As UInteger
        Public dwExtraInfo As IntPtr
    End Structure

    <StructLayout(LayoutKind.Sequential)>
    Private Structure HARDWAREINPUT
        Public uMsg As UInteger
        Public wParamL As UShort
        Public wParamH As UShort
    End Structure

    ' 定义常量
    Private Const INPUT_KEYBOARD As Integer = 1
    Private Const KEYEVENTF_KEYUP As UInteger = &H2
    Private Const MOUSEEVENTF_MOVE As UInteger = &H1
    Private Const MOUSEEVENTF_LEFTDOWN As UInteger = &H2
    Private Const MOUSEEVENTF_LEFTUP As UInteger = &H4

    ' 定义修饰键
    Private Const MOD_ALT As UInteger = &H1
    Private Const MOD_CONTROL As UInteger = &H2
    Private Const MOD_SHIFT As UInteger = &H4
    Private Const MOD_WIN As UInteger = &H8

    ' 定义热键ID
    Private Const HOTKEY_ID As Integer = 1

    ' 窗体加载时注册全局热键
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'RegisterHotKey(Me.Handle, HOTKEY_ID, MOD_CONTROL Or MOD_ALT, Keys.S)
        RegisterHotKey(Me.Handle, HOTKEY_ID, MOD_ALT, Keys.S)
    End Sub

    ' 窗体关闭时注销全局热键
    Protected Overrides Sub OnFormClosing(ByVal e As FormClosingEventArgs)
        UnregisterHotKey(Me.Handle, HOTKEY_ID)
        MyBase.OnFormClosing(e)
    End Sub

    ' 处理窗口消息
    Protected Overrides Sub WndProc(ByRef m As Message)
        If m.Msg = &H312 Then ' WM_HOTKEY消息
            Dim id As Integer = m.WParam.ToInt32()
            If id = HOTKEY_ID Then
                ' 调用你的子程序或函数
                ' CallMyFunction()
                SendCtrlAltD()
                Threading.Thread.Sleep(TextBox5.Text)
                DragMouse（TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text）
            End If
        End If
        MyBase.WndProc(m)
    End Sub

    ' 定义你的子程序或函数
    Private Sub CallMyFunction()
        MessageBox.Show("全局热键被按下!")
    End Sub


    ' 定义子程序，模拟按下和松开Ctrl+Alt+D键
    Private Sub SendCtrlAltD()
        Dim inputs(5) As INPUT

        ' 按下Ctrl键
        inputs(0).type = INPUT_KEYBOARD
        inputs(0).mkhi.ki.wVk = &H11 ' VK_CONTROL

        ' 按下Alt键
        inputs(1).type = INPUT_KEYBOARD
        inputs(1).mkhi.ki.wVk = &H12 ' VK_MENU

        ' 按下D键
        inputs(2).type = INPUT_KEYBOARD
        inputs(2).mkhi.ki.wVk = &H44 ' D键

        ' 松开D键
        inputs(3).type = INPUT_KEYBOARD
        inputs(3).mkhi.ki.wVk = &H44 ' D键
        inputs(3).mkhi.ki.dwFlags = KEYEVENTF_KEYUP

        ' 松开Alt键
        inputs(4).type = INPUT_KEYBOARD
        inputs(4).mkhi.ki.wVk = &H12 ' VK_MENU
        inputs(4).mkhi.ki.dwFlags = KEYEVENTF_KEYUP

        ' 松开Ctrl键
        inputs(5).type = INPUT_KEYBOARD
        inputs(5).mkhi.ki.wVk = &H11 ' VK_CONTROL
        inputs(5).mkhi.ki.dwFlags = KEYEVENTF_KEYUP

        ' 发送输入
        SendInput(CUInt(inputs.Length), inputs, Marshal.SizeOf(GetType(INPUT)))
    End Sub

    ' 定义模拟鼠标拖动的方法
    Private Sub DragMouse(x1 As Integer, y1 As Integer, x2 As Integer, y2 As Integer)
        ' 移动到起始位置并按下鼠标左键
        SetCursorPos(x1, y1)
        Threading.Thread.Sleep(TextBox6.Text)
        mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, IntPtr.Zero)
        Threading.Thread.Sleep(TextBox6.Text)
        ' 移动到目标位置
        SetCursorPos(x2, y2)
        Threading.Thread.Sleep(TextBox6.Text)
        ' 松开鼠标左键
        mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, IntPtr.Zero)
    End Sub


    ' 获取当前鼠标坐标的方法
    Private Function GetMousePosition() As Point
        Dim p As New Point()
        GetCursorPos(p)
        Return p
    End Function

    ' 异步方法，延时3秒后获取当前鼠标坐标
    Private Async Sub GetMousePositionWithDelayA()
        Await Task.Delay(3000) ' 延时3秒
        Dim pos As Point = GetMousePosition()
        'MessageBox.Show("当前鼠标坐标: X=" & pos.X & " Y=" & pos.Y)
        TextBox1.Text = pos.X
        TextBox2.Text = pos.Y
        Console.Beep(330, 500)
    End Sub

    Private Async Sub GetMousePositionWithDelayB()
        Await Task.Delay(3000) ' 延时3秒
        Dim pos As Point = GetMousePosition()
        ' MessageBox.Show("当前鼠标坐标: X=" & pos.X & " Y=" & pos.Y)
        TextBox3.Text = pos.X
        TextBox4.Text = pos.Y
        Console.Beep(330, 500)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Console.Beep(262, 500)
        GetMousePositionWithDelayA()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Console.Beep(262, 500)
        GetMousePositionWithDelayB()
    End Sub
End Class
