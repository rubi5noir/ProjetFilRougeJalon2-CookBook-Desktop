using APIProjetFilRouge.DAL.Interfaces;

namespace APIProjetFilRouge.DAL.UnitsOfWork
{
    public interface IUnitOfWork
    {

        IAvisRepository Avis { get; }
        ICategorieRepository Categorie { get; }
        ICompteRepository Compte { get; }
        IEtapeRepository Etape { get; }
        IIngredientRepository Ingredient { get; }
        IRecetteRepository Recette { get; }



        bool HasActiveTransaction { get; }

        void BeginTransaction();
        void Commit();
        void Rollback();
    }
}
