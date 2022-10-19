int[ , ] GetMass( int row, int col )
{
    int[ , ] matr = new int[ row, col ];
    for ( int i = 0; i < matr.GetLength( 0 ); ++i )
    {
        for ( int j = 0; j < matr.GetLength( 1 ); ++j )
        {
            matr[ i, j ] = i + j + 2;
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
            System.Console.Write( table[ i, j ] + "   " );
        }
        System.Console.WriteLine();
    }
}
int row = Convert.ToInt32( Console.ReadLine() );
int col = Convert.ToInt32( Console.ReadLine() );
int[ , ] table1 = GetMass( row, col );
PrintTable( table1 );
