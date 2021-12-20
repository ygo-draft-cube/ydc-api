import subprocess
import os

prefix = 'ygo-draft-api-functions'
project_tag = 'ygo-draft-sls'

project_names = [
  # Hello World (Example Test Project)
  'hello-world',
  # Draft List
  'draft-list'
]
template_files = [
  # Hello World (Example Test Project)
  './HelloWorld/src/HelloWorld/serverless.template',
  # Draft List
  './DraftList/src/DraftList/serverless.template'
]

for project_name,template_file in zip(project_names, template_files):
  template_file_location = os.path.join(os.getcwd(), template_file)
  stack_name = f"{prefix}-{project_name}"
  s3_bucket = f"{prefix}-{project_name}"
  process = subprocess.run([
    'dotnet', 'lambda', 'deploy-serverless', '--stack-name', stack_name, '--s3-bucket', s3_bucket, '--tags', f'Project={project_tag}', '--region', 'us-east-1', '-t', template_file_location
  ])
