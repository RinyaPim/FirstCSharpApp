Console.WriteLine("Name: นายปริญญา ไชยรส");
Console.WriteLine("Course: Advanced Programming");
Console.WriteLine("Introduction: ผมเป็นนักศึกษาปีที่ 3 จะตั้งใจเรียนครับ");
Console.WriteLine("---------------------------------");

Console.WriteLine("โปรแกรมแนะนำตัวเอง");
Console.WriteLine("โปรดกรอกข้อมูลของคุณ");

String name = Console.ReadLine();
Console.WriteLine("Hello, " + name + "!.");
Console.WriteLine("---------------------------------");
Console.WriteLine("ขอบคุณที่ใช้โปรแกรมนี้");

strLine("-", 30);
void strLine( string strInput , int n)
{
    string strOutput = "";
    for (int i = 0; i < n; i++)
    {
        strOutput += strInput;
    }
    Console.WriteLine(strOutput);
}
