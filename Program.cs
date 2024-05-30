using laba_5;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Введите ФИО спортсмена");
            string athleteName = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(athleteName)) 
            {
                throw new Exception("ФИО спортсмена не было введено");
            }

            if (athleteName.Any(char.IsDigit) ) 
            {
                throw new Exception("ФИО спортсмена не должно состоять из цифр");
            }

            Console.WriteLine("Введите время спортсмена ( в секундах)");
            string timeInput = Console.ReadLine();

            if (double.TryParse(timeInput, out double time)) 
            {
                if (time == 0)
                {
                    throw new TimeCannotBeZeroException();
                }
                Console.WriteLine($"Спортсмен: {athleteName},время: {timeInput}");
            }
            else
            {
                throw new Exception("Введеное значение не является числом.Пожалуйста введите корректное число");
            }
        }
        catch (TimeCannotBeZeroException ex)
        {
            Console.WriteLine(ex.Message);
            return;
        }
        catch (Exception ex) when (ex.Message == "ФИО спортсмена не было введено" )
        {
            Console.WriteLine(ex.Message);
            return ;
        }
        catch (Exception ex) when (ex.Message == "ФИО спортсмена не должно состоять из цифр")
        {
            Console.WriteLine(ex.Message);
            return;
        }
        catch (Exception ex) when (ex.Message == "Введеное значение не является числом.Пожалуйста введите корректное число")
        {
            Console.WriteLine(ex.Message);
            return;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Неизвестный тип исключения");
            Console.WriteLine(ex.Message);
            return;
        }

        Console.WriteLine("Закончилось");
    }
}