using System;

namespace ZeroScope.UI
{
    public class ArgsShotInfoRetriever : IShotInfoRetriever
    {

        private const int TARGET_DISTANCE_IDX = 0;
        private const int HORIZONTAL_OFFSET_IDX = 1;
        private const int VERTICAL_OFFSET_IDX = 2;

        private string[] args;

        public ArgsShotInfoRetriever(string[] args)
        {
            if (args == null || args.Length < VERTICAL_OFFSET_IDX + 1) throw new Exception("Invalid args");
            this.args = args;
        }

        public ShotInfo GetShotInfo()
        {
            var targetDist = Decimal.Parse(args[TARGET_DISTANCE_IDX]);
            var hOffset = Decimal.Parse(args[HORIZONTAL_OFFSET_IDX]);
            var vOffset = Decimal.Parse(args[VERTICAL_OFFSET_IDX]);

            return new ShotInfo
            {
                VerticalBulletOffset = vOffset,
                HorizontalBulletOffset = hOffset,
                ShootingDistance = targetDist
            };
        }
    }
}
