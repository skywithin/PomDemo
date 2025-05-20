To create a migration, use the following command in the terminal:
```
Add-Migration <MigrationName>
```

To apply the migration to the database, use the following command:

You can also use the `Update-Database` command to apply all pending migrations. 
In this case, you don't need to specify a migration name.
```
Update-Database [MigrationName]
```