pipeline {
  agent any
  stages {
    stage('Hello') {
      steps { echo 'Jenkins is running on the VM 🎉' }
    }
  }
}
