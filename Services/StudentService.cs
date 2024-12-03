using Skynet.ERP.Domains;
/*
Author Name: Osama khodrog
Created Date: 25/11/2024
Update Date 
    1- 25/11/2024 - Add new methods and enhance some point - Osama
    2- 28/11/2024 - Add new methods and enhance some point - Ali
 */
namespace Skynet.ERP.Services
{
    public class StudentService : IStudent
    {
        #region Variables

        private List<Student> _students;

        #endregion

        #region Constractors

        public StudentService()
        {
            if (_students == null)
            {
                _students = new List<Student>();
            }
        }

        #endregion

        #region Methods

        #region Public Methods

        public OpStatus Insert(Student student)
        {
            try
            {
                var enc = BCrypt.Net.BCrypt.HashPassword(student.Password);

                student.Password = enc;
                _students.Add(student);
                return OpStatus.Added;
            }
            catch (Exception ex)
            {
                var error = ex.Message;
                Console.WriteLine("We are sorry for this issues, please try again later :(");
                return OpStatus.Error;
            }
            finally
            {
                //
            }
        }

        public List<Student> GetAll()
        {
            try
            {
                var studentList = _students.ToList();
                return studentList;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public OpStatus Delete(Student student)
        {
            try
            {
                _students.Remove(student);
                return OpStatus.Sucess;
            }
            catch (Exception)
            {
                return OpStatus.Error;
            }
        }

        public Student GetById(int studentId)
        {
            try
            {
                var student = _students.Where(q => q.Id == studentId).FirstOrDefault();
                return student;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public OpStatus Update(Student student)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Private Methods

        #endregion

        #endregion
    }
}
