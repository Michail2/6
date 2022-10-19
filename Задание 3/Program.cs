int[ , ] GetMass( int row, int col, int minValue, int maxValue )
{
    int[,] matr = new int[ row, col ];
    for ( int i = 0; i < matr.GetLength( 0 ); ++i )
    {
        for ( int j = 0; j < matr.GetLength( 1 ); ++j )
        {
            matr[ i, j ] = new Random().Next( minValue , maxValue );
            
            if ( i % 2 == 0  & j % 2 == 0  )
                {
                matr[ i , j ] = matr[ i , j ] * matr[ i , j ];
                }
        }
    }

    return matr;
}


void PrintTable( int[ , ] table )
{
    for ( int i = 0; i < table.GetLength( 0 ); ++i )
    {
        for ( int j = 0; j < table.GetLength( 1 ); ++j )
        {                
                Console.Write( table[ i, j ] + " " );  
        }   
          Console.WriteLine();
    }
}
int row = Convert.ToInt32( Console.ReadLine() );
int col = Convert.ToInt32( Console.ReadLine() );
int minValue = Convert.ToInt32( Console.ReadLine() );
int maxValue = Convert.ToInt32( Console.ReadLine() );

int[ , ] table1 = GetMass( row, col, minValue, maxValue );
PrintTable( table1 );

