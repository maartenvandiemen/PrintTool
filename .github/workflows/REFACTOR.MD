# Exercise build
Improve the pipeline:
1. Give more readable names to the steps. So it's more clear what's happening in the build.
   - Hint: use displayname
1. Add unit tests as part of the build.
   - [Hint](https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-test)
1. Introducing variables
1. Skip the Linux part by default, but can be configured with variables settable at queue time.
1. Protect a branch, add conditions to the workflow that if a PR triggers the pipeline, the release part must be skipped.
   - [Hint](https://docs.github.com/en/actions/using-jobs/using-conditions-to-control-job-execution)
1. By splitting the generic logic for builds to a action or workflow
   - [Hint composite actions](https://docs.github.com/en/actions/creating-actions/creating-a-composite-action)
   - [Hint reusable workflow](https://docs.github.com/en/actions/using-workflows/reusing-workflows)
1. And store the template above in a seperate repo
1. Implement caching for the packages
   - [Hint](https://docs.github.com/en/actions/using-workflows/caching-dependencies-to-speed-up-workflows)
1. Build the application for multiple applications by applying `strategy` and `matrix` 
   - [Hint](https://docs.github.com/en/actions/using-jobs/using-a-matrix-for-your-jobs)

# Exercise release
Improve the pipeline:
1. Add approvers to the different stages
1. By splitting the generic logic for releases to a action or workflow
   - [Hint composite actions](https://docs.github.com/en/actions/creating-actions/creating-a-composite-action)
   - [Hint reusable workflow](https://docs.github.com/en/actions/using-workflows/reusing-workflows)
1. Split the multi-stage YAML pipeline in a seperate build en seperate release.
