# SSC-Internship-Dev-CSharpBasic
# Hướng Dẫn Về C# Cơ Bản
### Giới thiệu C#:
  - C# là một ngôn ngữ lập trình đa mục đích, được phát triển bởi Microsoft. Nó hỗ trợ lập trình hướng đối tượng, lập trình hàm và lập trình cấu trúc. C# được thiết kế để dễ học và dễ sử dụng, đồng thời cung cấp các tính năng mạnh mẽ cho việc phát triển ứng dụng.
## 1. Biến, Kiểu Dữ Liệu và Toán Tử
### Biến (Variables)
- Định Nghĩa:
  - Biến là một vùng nhớ được đặt tên dùng để lưu trữ dữ liệu mà chương trình có thể sử dụng và thay đổi. Biến có loại dữ liệu cụ thể và phải được khai báo trước khi sử dụng.
- Ví Dụ:
  ```csharp
  int age = 30;
  string name = "John Doe";
- Giải Thích:
  - int age khai báo một biến age kiểu số nguyên.
  - string name khai báo một biến name kiểu chuỗi.
### Kiểu Dữ Liệu (Data Types)
- Định Nghĩa:
  - Kiểu dữ liệu xác định loại giá trị mà một biến có thể lưu trữ. C# hỗ trợ nhiều kiểu dữ liệu, bao gồm kiểu dữ liệu nguyên thủy và kiểu dữ liệu phức tạp.
- Các Kiểu Dữ Liệu Chính:
  - Kiểu Nguyên Thủy: int, double, char, bool
  - Kiểu Dữ Liệu Phức Tạp: string, array
- Ví Dụ:
  ```csharp
  double height = 5.9;
  char initial = 'J';
  bool isStudent = true;
- Giải Thích:
  - double height lưu trữ một số thực.
  - char initial lưu trữ một ký tự.
  - bool isStudent lưu trữ giá trị đúng/sai.
### Toán Tử (Operators)
- Định Nghĩa:
  - Toán tử là các ký hiệu hoặc ký tự được sử dụng để thực hiện các phép toán trên biến và giá trị.
- Các Loại Toán Tử Chính:
  - Toán Tử Số Học: +, -, *, /, %
  - Toán Tử So Sánh: ==, !=, >, <, >=, <=
  - Toán Tử Logic: &&, ||, !
- Ví Dụ:
  ```csharp
  int sum = 5 + 3;   // Tổng = 8
  bool isEqual = (5 == 5);   // True
  bool isTrue = (true && false);  // False
- Giải Thích:
  - + thực hiện phép cộng.
  - == kiểm tra sự bằng nhau.
  - && thực hiện phép AND logic.
## 2. Mảng (Array), Enum, Nullable
### Mảng (Array)
- Định Nghĩa:
  - Mảng là một cấu trúc dữ liệu cho phép lưu trữ nhiều giá trị cùng loại dưới một tên biến. Các giá trị được lưu trữ trong mảng có thể được truy cập qua chỉ số (index).
- Ví Dụ:
  ```csharp
  int[] numbers = {1, 2, 3, 4, 5};
  string[] names = new string[3] {"Alice", "Bob", "Charlie"};
- Giải Thích:
  - int[] numbers khai báo một mảng số nguyên với các giá trị từ 1 đến 5.
  - string[] names khai báo một mảng chuỗi với ba tên.
### Enum
- Định Nghĩa:
  - Enum (enumeration) là một kiểu dữ liệu đặc biệt cho phép bạn định nghĩa một tập hợp các hằng số có tên.
- Ví Dụ:
  ```csharp
  enum Day { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday }
  Day today = Day.Wednesday;
- Giải Thích:
  - enum Day định nghĩa các giá trị của các ngày trong tuần.
  - Day today = Day.Wednesday gán giá trị Wednesday cho biến today.
### Nullable
- Định Nghĩa:
- Nullable cho phép một kiểu dữ liệu có thể chứa giá trị null ngoài các giá trị thông thường.
- Ví Dụ:
  ```csharp
  int? age = null;
- Giải Thích:
  - int? cho phép biến age lưu trữ giá trị số nguyên hoặc null.
## 3. Điều Kiện và Vòng Lặp
### Điều Kiện (If, Switch)
- If:
  - Định Nghĩa:
    - Câu lệnh if được sử dụng để thực hiện một khối mã dựa trên một điều kiện.
  - Ví Dụ:
    ```csharp
    int number = 10;
    if (number > 0)
    {
        Console.WriteLine("Number is positive.");
    }
  - Giải Thích:
    - Câu lệnh if kiểm tra nếu number lớn hơn 0 và in ra thông báo nếu điều kiện đúng.
- Switch:
  - Định Nghĩa:
    - Câu lệnh switch cho phép bạn kiểm tra một biến với nhiều giá trị khác nhau.
  - Ví Dụ:
    ```csharp
    Day day = Day.Monday;
    switch (day)
    {
        case Day.Monday:
            Console.WriteLine("Start of the week.");
            break;
        case Day.Friday:
            Console.WriteLine("End of the week.");
            break;
    }
  - Giải Thích:
    - Câu lệnh switch kiểm tra giá trị của day và thực hiện khối mã tương ứng với từng giá trị.
### Vòng Lặp (For, While, Do-While)
- For:
  - Định Nghĩa:
    - Vòng lặp for lặp qua một khối mã với số lần lặp xác định.
  - Ví Dụ:
    ```csharp
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine(i);
    }
  - Giải Thích:
    - Vòng lặp for in các số từ 0 đến 4.
- While:
  - Định Nghĩa:
    - Vòng lặp while lặp qua một khối mã miễn là điều kiện được xác định là đúng.
  - Ví Dụ:
    ```csharp
    int i = 0;
    while (i < 5)
    {
        Console.WriteLine(i);
        i++;
    }
  - Giải Thích:
    - Vòng lặp while in các số từ 0 đến 4 và tăng giá trị của i trong mỗi lần lặp.
- Do-While:
  - Định Nghĩa:
    - Vòng lặp do-while lặp qua một khối mã ít nhất một lần, sau đó tiếp tục lặp nếu điều kiện đúng.
  - Ví Dụ:
    ```csharp
    int i = 0;
    do
    {
        Console.WriteLine(i);
        i++;
    } while (i < 5);
  - Giải Thích:
    - Vòng lặp do-while giống như while, nhưng đảm bảo rằng khối mã được thực hiện ít nhất một lần.
## 4. Lớp (Class), Constructor, Thuộc Tính (Property), Phương Thức (Method), Phạm Vi Truy Cập (Access Modifiers)
### Lớp (Class)
  - Định Nghĩa:
    - Lớp là một mẫu (template) cho các đối tượng. Nó định nghĩa thuộc tính và phương thức mà các đối tượng được tạo từ lớp đó sẽ có.
  - Ví Dụ:
    ```csharp
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
    
        public void StartEngine()
        {
            Console.WriteLine("Engine started");
        }
    }
  - Giải Thích:
    - Lớp Car định nghĩa các thuộc tính và phương thức cho các đối tượng kiểu Car.
### Constructor
- Định Nghĩa:
  - Constructor là một phương thức đặc biệt được gọi khi một đối tượng được tạo. Nó thường được sử dụng để khởi tạo các thuộc tính của lớp.
  - Ví Dụ:
    ```csharp
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
    
        public Car(string brand, string model, int year)
        {
            Brand = brand;
            Model = model;
            Year = year;
        }
    }
  - Giải Thích:
    - Constructor Car(string brand, string model, int year) được sử dụng để khởi tạo một đối tượng Car với các giá trị cụ thể cho thuộc tính Brand, Model, và Year.
### Thuộc Tính (Property)
  - Định Nghĩa:
    - Thuộc tính là các thành phần của lớp cho phép bạn đọc, ghi hoặc tính toán giá trị của các trường (fields) mà không cần phải truy cập trực tiếp.
  - Ví Dụ:
    ```csharp
    public class Person
    {
        private string name;
    
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
  - Giải Thích:
    - Thuộc tính Name cho phép bạn truy cập và thay đổi giá trị của trường name một cách an toàn.
### Phương Thức (Method)
- Định Nghĩa:
  - Phương thức là các chức năng hoặc hành động mà lớp có thể thực hiện. Nó có thể nhận các tham số và trả về một giá trị.
- Ví Dụ:
    ```csharp
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
- Giải Thích:
  - Phương thức Add thực hiện phép cộng hai số nguyên và trả về kết quả.
### Phạm Vi Truy Cập (Access Modifiers)
- Định Nghĩa:
  - Phạm vi truy cập xác định mức độ truy cập vào các thành phần của lớp.
- Các Loại Phạm Vi Truy Cập:
  - public: Có thể truy cập từ bất kỳ đâu.
  - private: Chỉ có thể truy cập trong cùng một lớp.
  - protected: Có thể truy cập trong cùng một lớp và các lớp dẫn xuất.
  - internal: Có thể truy cập trong cùng một assembly.
- Ví Dụ:
  ```csharp
  public class Person
  {
      private string name; // private field
  
      public string Name // public property
      {
          get { return name; }
          set { name = value; }
      }
  }
- Giải Thích:
  - Trường name có phạm vi truy cập private, trong khi thuộc tính Name có phạm vi truy cập public.
## 5. Kiểu Dữ Liệu (Value Types) và Kiểu Tham Chiếu (Reference Types)
### Kiểu Dữ Liệu (Value Types)
- Định Nghĩa:
  - Kiểu dữ liệu giá trị lưu trữ dữ liệu trực tiếp và các biến kiểu giá trị không chia sẻ dữ liệu với các biến khác.
- Các Kiểu Dữ Liệu Giá Trị:
  - Số Nguyên: int, short, long
  - Số Thực: float, double
  - Ký Tự: char
  - Boolean: bool
- Ví Dụ:
  ```csharp
  int a = 10;
  int b = a; // b có giá trị 10, không bị ảnh hưởng bởi sự thay đổi của a
  a = 20;
- Giải Thích:
  - Khi a được thay đổi, b vẫn giữ giá trị cũ là 10 vì a và b lưu trữ giá trị riêng biệt.
### Kiểu Tham Chiếu (Reference Types)
- Định Nghĩa:
  - Kiểu dữ liệu tham chiếu lưu trữ địa chỉ của đối tượng trong bộ nhớ. Các biến kiểu tham chiếu chia sẻ dữ liệu với các biến khác.
- Các Kiểu Dữ Liệu Tham Chiếu:
  - Chuỗi: string
  - Mảng: array
  - Lớp: class
  - Giao Diện: interface
- Ví Dụ:
  ```csharp
  class Person
  {
      public string Name { get; set; }
  }
  
  Person p1 = new Person();
  p1.Name = "Alice";
  
  Person p2 = p1; // p2 tham chiếu đến cùng đối tượng với p1
  p2.Name = "Bob";
  
  Console.WriteLine(p1.Name); // In ra "Bob"
- Giải Thích:
  - p1 và p2 tham chiếu đến cùng một đối tượng trong bộ nhớ, do đó thay đổi qua p2 cũng ảnh hưởng đến p1.
## 6. Bài tập tự luyện
- Bài tập 1: Khai báo các biến để lưu trữ thông tin về một người: tên, tuổi, chiều cao, điểm trung bình và trạng thái hoạt động (active). In ra các giá trị này.
- Bài tập 2: Sử dụng các toán tử số học để tính chu vi và diện tích của một hình chữ nhật với chiều dài và chiều rộng được nhập vào từ bàn phím.
- Bài tập 3: Kiểm tra xem một số nhập từ bàn phím có phải là số chẵn hay không sử dụng toán tử %.
- Bài tập 4: Tạo một mảng lưu trữ danh sách các số nguyên, sau đó tính tổng và trung bình của các số trong mảng.
- Bài tập 5: Tạo một enum cho các ngày trong tuần. Viết một hàm để in ra ngày trong tuần dựa trên chỉ số.
- Bài tập 6: Viết một chương trình yêu cầu người dùng nhập điểm số, nếu người dùng không nhập gì, gán giá trị null cho điểm đó và xử lý trường hợp này bằng Nullable.
- Bài tập 7: Viết chương trình kiểm tra số nguyên nhập từ bàn phím là dương, âm hay bằng 0, sử dụng câu lệnh if.
- Bài tập 8: Viết chương trình cho phép người dùng nhập vào một số từ 1 đến 7 và in ra ngày tương ứng trong tuần, sử dụng câu lệnh switch.
- Bài tập 9: Sử dụng vòng lặp for để in ra các số chẵn từ 1 đến 100.
- Bài tập 10: Sử dụng vòng lặp while để tính tổng các số từ 1 đến một số nguyên dương n được nhập từ bàn phím.
- Bài tập 11: Sử dụng vòng lặp do_while để yêu cầu người dùng nhập một số nguyên dương. Nếu số đó không phải là số nguyên dương, yêu cầu nhập lại.
- Bài tập 12: Tạo một lớp Car với các thuộc tính Brand, Model, Year. Viết một constructor để khởi tạo đối tượng Car, và một phương thức để in thông tin xe.
- Bài tập 13: Tạo lớp Student với các thuộc tính Name, Age, Grade. Viết các phương thức Study và TakeExam. Sử dụng các access modifiers để bảo vệ dữ liệu.
- Bài tập 14: Tạo lớp BankAccount với các thuộc tính AccountNumber, Balance. Viết phương thức Deposit và Withdraw, sử dụng properties để kiểm soát truy cập vào số dư tài khoản.
- Bài tập 15: Tạo một cấu trúc Point (kiểu giá trị) với các thuộc tính X, Y để lưu trữ tọa độ của một điểm. Viết một phương thức để in tọa độ của điểm.
- Bài tập 16: Tạo một lớp Rectangle (kiểu tham chiếu) với các thuộc tính Width, Height. Viết một phương thức để tính diện tích của hình chữ nhật.
- Bài tập 17: Tạo một lớp Circle với thuộc tính Radius. Tạo một mảng các đối tượng Circle và tính tổng diện tích của tất cả các hình tròn.
## 7. Nguồn tham khảo
- https://www.w3schools.com/cs/index.php
