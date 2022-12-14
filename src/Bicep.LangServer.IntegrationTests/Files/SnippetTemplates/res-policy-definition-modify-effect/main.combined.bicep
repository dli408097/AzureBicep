// $1 = policyDefinition
// $2 = 'name'
// $3 = 'displayName'
// $4 = 'Custom'
// $5 = 'Indexed'
// $6 = 'description'
// $7 = '0.1.0'
// $8 = 'category'
// $9 = 'source'
// $10 = parameterName
// $11 = 'String'
// $12 = 'defaultValue'
// $13 = 'displayName'
// $14 = 'description'
// $15 = allOf
// $16 = 'field'
// $17 = equals
// $18 = 'conditionValue'
// $19 = 'Modify'
// $20 = '/providers/Microsoft.Authorization/roleDefinitions/b24988ac-6180-42a0-ab88-20f7382dd24c'
// $21 = 'addOrReplace'
// $22 = 'field'
// $23 = 'value'
targetScope = 'subscription'
resource policyDefinition 'Microsoft.Authorization/policyDefinitions@2020-09-01' = {
  name: 'name'
  properties: {
    displayName: 'displayName'
    policyType: 'Custom'
    mode: 'Indexed'
    description: 'description'
    metadata: {
      version: '0.1.0'
      category: 'category'
      source: 'source'
    }
    parameters: {
      parameterName: {
        type: 'String'
        defaultValue: 'defaultValue'
        metadata: {
          displayName: 'displayName'
          description: 'description'
        }
      }
    }
    policyRule: {
      if: {
        allOf: [
          {
            field: 'field'
            equals: 'conditionValue'
          }
        ]
      }
      then: {
        effect: 'Modify'
        details: {
          roleDefinitionIds: [
            '/providers/Microsoft.Authorization/roleDefinitions/b24988ac-6180-42a0-ab88-20f7382dd24c'
          ]
          operations: [
            {
              operation: 'addOrReplace'
              field: 'field'
              value: 'value'
            }
          ]
        }
      }
    }
  }
}


