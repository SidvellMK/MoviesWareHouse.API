using Contracts;
using Entities;

namespace Repository
{
    public class RepositoryWrapper: IRepositoryWrapper
    {
        private RepositoryContext _repoContext;
        private IAccountRepository _account;
        private IOwnerRepository _owner;
        private IMovieRepository _movie;

        public IOwnerRepository Owner
        {
            get
            {
                if (_owner == null)
                {
                    _owner = new OwnerRepository(_repoContext);
                }
                return _owner;
            }
        }

        public IAccountRepository Account
        {
            get
            {
                if (_account == null)
                {
                    _account = new AccountRepository(_repoContext);
                }
                return _account;
            }
        }
        public IMovieRepository Movie
        {
            get
            {
                if (_movie == null)
                {
                    _movie = new MovieRepository(_repoContext);
                }
                return _movie;
            }
        }

        public RepositoryWrapper(RepositoryContext repositoryContext)
        {
            _repoContext = repositoryContext;
        }
    }
}
