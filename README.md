# testPVS

1. Проект внутри репозитория.
2.

   ```
   [TestMethod]
   public void TestMethod1()
   {
     Assert.IsTrue(TestProgram.RandomInt() % 2 == 0);
   }
   ```
3. 

```
pipeline {
    agent any

    stages {
        stage('clonning') {
            steps {
            //bat 'exit 0'
            bat 'git clone https://github.com/TheLivan/testPVS.git'
            }
        }
        
        stage('work') {
            steps {
                bat '''
                chcp 1251
                cd testPVS
                dotnet test
                '''
            }
        }
    }
}
```

4.
```
@daily
```
