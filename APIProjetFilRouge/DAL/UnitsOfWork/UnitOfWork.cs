using APIProjetFilRouge.DAL.Interfaces;
using APIProjetFilRouge.DAL.Session;

namespace APIProjetFilRouge.DAL.UnitsOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDBSession _dbSession;
        private readonly Lazy<IAvisRepository> _avis;
        private readonly Lazy<ICategorieRepository> _categorie;
        private readonly Lazy<ICompteRepository> _compte;
        private readonly Lazy<IEtapeRepository> _etape;
        private readonly Lazy<IIngredientRepository> _ingredient;
        private readonly Lazy<IRecetteRepository> _recette;

        public UnitOfWork(IDBSession dbSession, IServiceProvider serviceProvider)
        {
            _dbSession = dbSession;
            _avis = new Lazy<IAvisRepository>(() => serviceProvider.GetRequiredService<IAvisRepository>());
            _categorie = new Lazy<ICategorieRepository>(() => serviceProvider.GetRequiredService<ICategorieRepository>());
            _compte = new Lazy<ICompteRepository>(() => serviceProvider.GetRequiredService<ICompteRepository>());
            _etape = new Lazy<IEtapeRepository>(() => serviceProvider.GetRequiredService<IEtapeRepository>());
            _ingredient = new Lazy<IIngredientRepository>(() => serviceProvider.GetRequiredService<IIngredientRepository>());
            _recette = new Lazy<IRecetteRepository>(() => serviceProvider.GetRequiredService<IRecetteRepository>());
        }

        #region Repositories

        public IAvisRepository Avis => _avis.Value;
        public ICategorieRepository Categorie => _categorie.Value;
        public ICompteRepository Compte => _compte.Value;
        public IEtapeRepository Etape => _etape.Value;
        public IIngredientRepository Ingredient => _ingredient.Value;
        public IRecetteRepository Recette => _recette.Value;

        #endregion Repositories

        #region Transactions

        public bool HasActiveTransaction => _dbSession.HasActiveTransaction;

        public void BeginTransaction()
            => _dbSession.BeginTransaction();

        public void Commit()
            => _dbSession.Commit();

        public void Rollback()
            => _dbSession.Rollback();

        #endregion Transactions
    }
}
