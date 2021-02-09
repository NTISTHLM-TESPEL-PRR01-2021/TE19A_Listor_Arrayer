using System.Runtime.Serialization;
using System;
using System.Collections.Generic;

namespace Arrayer
{
  class Program
  {
    static void Main(string[] args)
    {
      // int[] enemyHp = new int[10];

      // int p = 3;

      // enemyHp[p] = 100;

      // 0 0 0 100 0 0 0 0 0 0
      // 0 1 2 3   4 5 6 7 8 9

      // int[] enemyHp = {100, 100, 50, 233, 512, 66};

      // int[] enemyHpNew = new int[enemyHp.Length + 1];
      // enemyHpNew[0] = enemyHp[0];
      // enemyHpNew[1] = enemyHp[1];
      // enemyHpNew[2] = enemyHp[2];
      // enemyHpNew[3] = enemyHp[3];
      // enemyHpNew[4] = enemyHp[4];
      // enemyHpNew[5] = 400;
      // enemyHp = enemyHpNew;


      // 100 100 50 233 512
      // 0   1   2  3   4

      // enemyHp[2] = enemyHp[2] + 100;

      List<int> enemyHp = new List<int>() {100, 100, 50, 233, 512, 66};

      // enemyHp.Add(100);

      // enemyHp.RemoveAll(e => e < 150);

      // for (int i = 0; i < enemyHp.Count; i++)
      // {
      //   enemyHp[i] -= 10;
      // }

      // enemyHp.RemoveAll(e => e <= 0);

      // int i = 0;
      // while (i < 3)
      // {

      //   i++;
      // }

      enemyHp = DamageAllEnemies(enemyHp, 10);
      
      // 100
      // 0

      // Console.WriteLine(String.Join(',', enemyHp));
      Console.WriteLine(enemyHp[0]);

      Console.ReadLine();

    }

    public static List<int> DamageAllEnemies(List<int> enemyHp, int damage)
    {

      for (int i = 0; i < enemyHp.Count; i++)
      {
        enemyHp[i] -= damage;
      }

      return enemyHp;
    }
  }
}
