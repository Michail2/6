double[ , ] GetMass( int row, int col )
{
    double[ , ] matr = new double[ row, col ];
    for ( int i = 0; i < matr.GetLength( 0 ); ++i )
    {
        for ( int j = 0; j < matr.GetLength(1); ++j )
        {
            matr[ i , j ] = new Random().NextDouble();
        }
    }

    return matr;
}

void PrintTable( double[ , ] table )
{
    for ( int i = 0; i < table.GetLength( 0 ); ++i )
    {
        for ( int j = 0; j < table.GetLength(1); ++j )
        {
            System.Console.Write( table[ i, j ] + " " );
        }
        System.Console.WriteLine();
    }
}
int row = Convert.ToInt32( Console.ReadLine() );
int col = Convert.ToInt32( Console.ReadLine() );

double[ , ] table1 = GetMass( row, col );
PrintTable( table1 );
