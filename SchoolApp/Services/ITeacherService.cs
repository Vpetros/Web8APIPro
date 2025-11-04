using SchoolApp.DTO;

namespace SchoolApp.Services
{
    public interface ITeacherService
    {
        Task<UserReadOnlyDTO> SignUpUserAsync(TeacherSignUpDTO request);
    }
}
