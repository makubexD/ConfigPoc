# Welcome to "Config - Proof of Concept (Various)"

### Main Goal
The idea of this repo is give us the freedom to create/run/test any stuff related to code and easily share with the guys mainly from the team or others interested by using git approach (creations of branches, pull requests, ...)

### Examples of usages
* There is task to create a new Javascript Rule in LM, instead of running locally or even worst directly in LM and waste time deploying. We can use the Javascript branch and also write some test in order to make sure everything is ok.
* We might need to create/update a new functionality in the repo of Plugins, we can use the proper branch or just create a new one from master and start playing and once it's working and if we are not sure create a PR or just present it during the code review call, anyone can commit or leave a message as part of the revision of pairs. 
* And others ...

### Benefits
* In some way, invite the team to the usage of collaborative work (Git).
* Try to always TEST everything, this might reduce errors, bugs, defects and TIME. 


## Working with ConfigPoc
* NEVER commit on master since is just a template, the idea is always to work on the pre-defined branches. Or create a branch from master and from there start doing everything. **Don't merge it directly at least you are 100% sure and don't forget to align with develop for future development**
* When a PR is created just mark as reviewers to the ones involved in the project/idea/concern. We want to avoid emails from stash :D 
* From these features/branches, we might create new branches. We don't need to merge them against the parent branch, at least we want to modify the template for future developments.


## File Structure
This is the template for developing applications and might change, there is no standard to create your own branch, keep the main base only and improve it :D
```
<master>
 ├──<feature/Javascript>                        * Support for node and basic template to start with Jest as part of Unit Testing
 |      |──feature/JavascriptTest-HLTH-XXXX     * e.g. A card to handle some complex logic as part of a Javascript Rule, CSS, HTML, forms, etc.
 |      |──feature/JavascriptTest-OwnStuff      
 |      |──feature/JavascriptTestWhatever
 ├──<feature/DotNet>                            * Support for net core and xUnit (Simple console app)
 │      ├──feature/DotNet
 │
 │
 └──<feature/XYZ>                               * Any other branch with another tech stack
```

## Installing
* `clone` the repo.
    ```bash
    git clone -b <branch> <remote_repo>
    e.g.
        git clone -b feature/Javascript https://stash.cignium.com/scm/cc/ConfigPoc.git
        git clone -b feature/DotNet https://stash.cignium.com/scm/cc/ConfigPoc.git
        git clone -b feature/XYZ https://stash.cignium.com/scm/cc/ConfigPoc.git
    ```
* Open your console and navigate to the folder of your workspace. e.g. `C:\..\ConfigTeam\`
    * For VS Code users you can type: `code .` to open code in the current location and then use the embedded console. If `code .` command doesn't work you should take a look to (https://code.visualstudio.com/docs/setup/windows)
    * IDE from any preference.

## Running the app
Might depend from the approach we want to try and the branch we have choose 
