namespace ProyectoX.Aplicacion.Core
{
    public interface IBaseService<TModelAdd, TModelMod, TModelRem>
    {
        ServiceResult get();
        ServiceResult GetById(int id);
        ServiceResult Save(TModelAdd model);
        ServiceResult Update(TModelMod model);
        ServiceResult Remove(TModelRem model);
    }
}