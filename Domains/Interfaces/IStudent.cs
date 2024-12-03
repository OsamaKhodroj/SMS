namespace Skynet.ERP.Domains
{
    public interface IStudent
    {
        public OpStatus Insert(Student student);
        public OpStatus Update(Student student);
        public OpStatus Delete(Student student);
        public List<Student> GetAll();
        public Student GetById(int studentId);
    }
}
