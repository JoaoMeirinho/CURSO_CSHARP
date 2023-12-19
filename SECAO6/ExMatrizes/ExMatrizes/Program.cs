string[] nums = Console.ReadLine().Split(' ');
int rows = int.Parse(nums[0]);
int cols = int.Parse(nums[1]);

int[,] mat = new int[rows, cols];

for (int i = 0; i < rows; i++)
{
    string[] values = Console.ReadLine().Split(' ');

    for (int j = 0; j < cols; j++)
    {
        mat[i,j] = int.Parse(values[j]);
    }
}

int numSearched = int.Parse(Console.ReadLine());

//descobrir números ao redor
for (int i = 0;i < rows; i++)
{
    for (int j = 0;j < cols; j++)
    {
        if (mat[i,j] == numSearched)
        {
            Console.WriteLine($"Position {i}, {j}:");

            //Se há número acima
            if(i - 1 >= 0)
            {
                Console.WriteLine($"UP: {mat[i - 1, j]}");
            }

            //Se há número a direita
            if(j + 1 <= cols - 1)
            {
                Console.WriteLine($"RIGHT: {mat[i, j + 1]}");
            }

            //Se há número abaixo
            if(i + 1 <= rows - 1)
            {
                Console.WriteLine($"DOWN: {mat[i + 1, j]}");
            }

            //Se há número a esquerda
            if(j - 1 >= 0)
            {
                Console.WriteLine($"LEFT: {mat[i, j - 1]}");
            }
        }
    }
}
