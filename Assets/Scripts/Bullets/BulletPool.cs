
using System.Collections.Generic;

namespace CosmicCuration.Bullets
{
    public class BulletPool
    {
        private BulletView bulletView;
        private BulletScriptableObject bulletScriptableObject;
        private List<PooledBullet> pooledBullets = new List<PooledBullet>();

        public BulletPool(BulletView bulletPrefab, BulletScriptableObject bulletSO)
        {
            this.bulletView = bulletPrefab;
            this.bulletScriptableObject = bulletSO;
        }

        public class PooledBullet
        {
            public BulletController bullet;
            public bool isUsed;
        }

    }
}
