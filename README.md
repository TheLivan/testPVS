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
               cleanWs()
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
5.
```
pipeline {
    agent any

    stages {
        stage('clonning') {
            steps {
                cleanWs()
                bat 'git clone https://github.com/TheLivan/testPVS.git'
            }
        }
        
        stage('work') {
            steps {
                bat '''
                chcp 1251
                cd testPVS
                docker build -f ConsoleApp1\\Dockerfile --force-rm -t worker2/try7 .
                docker run -i worker2/try7
                '''
            }
        }
    }
}
```
