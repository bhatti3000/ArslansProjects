pipeline {
  agent any
  options { timestamps() }

  stages {
    stage('Checkout') {
      steps { checkout scm }
    }
    stage('Hello') {
      steps { echo 'Jenkins is running on the VM 🎉' }
    }
  }
}
