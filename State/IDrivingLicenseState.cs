public interface IDrivingLicenseState<T>
{
    void EnterState(T context);
    void ExitState(T context);
}
