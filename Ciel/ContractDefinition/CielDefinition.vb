Imports System
Imports System.Threading.Tasks
Imports System.Collections.Generic
Imports System.Numerics
Imports Nethereum.Hex.HexTypes
Imports Nethereum.ABI.FunctionEncoding.Attributes
Imports Nethereum.Web3
Imports Nethereum.RPC.Eth.DTOs
Imports Nethereum.Contracts.CQS
Imports Nethereum.Contracts
Imports System.Threading
Namespace Crypto.Contracts.Ciel.ContractDefinition

    
    
    Public Partial Class CielDeployment
     Inherits CielDeploymentBase
    
        Public Sub New()
            MyBase.New(DEFAULT_BYTECODE)
        End Sub
        
        Public Sub New(ByVal byteCode As String)
            MyBase.New(byteCode)
        End Sub
    
    End Class

    Public Class CielDeploymentBase 
            Inherits ContractDeploymentMessage
        
        Public Shared DEFAULT_BYTECODE As String = "608060405234801561001057600080fd5b5033600090815260016020908152604080832061271090819055909255815180830190925260048083527f4369656c000000000000000000000000000000000000000000000000000000009290910191825261006e916003916100c2565b506004805460ff19168155604080518082019091528181527f4349454c0000000000000000000000000000000000000000000000000000000060209091019081526100bc91600591906100c2565b5061015d565b828054600181600116156101000203166002900490600052602060002090601f016020900481019282601f1061010357805160ff1916838001178555610130565b82800160010185558215610130579182015b82811115610130578251825591602001919060010190610115565b5061013c929150610140565b5090565b61015a91905b8082111561013c5760008155600101610146565b90565b6106d68061016c6000396000f3fe6080604052600436106100ae5763ffffffff7c010000000000000000000000000000000000000000000000000000000060003504166306fdde0381146100b3578063095ea7b31461013d57806318160ddd1461018a57806323b872dd146101b157806327e235e3146101f4578063313ce567146102275780635c6581651461025257806370a082311461028d57806395d89b41146102c0578063a9059cbb146102d5578063dd62ed3e1461030e575b600080fd5b3480156100bf57600080fd5b506100c8610349565b6040805160208082528351818301528351919283929083019185019080838360005b838110156101025781810151838201526020016100ea565b50505050905090810190601f16801561012f5780820380516001836020036101000a031916815260200191505b509250505060405180910390f35b34801561014957600080fd5b506101766004803603604081101561016057600080fd5b50600160a060020a0381351690602001356103d7565b604080519115158252519081900360200190f35b34801561019657600080fd5b5061019f61043d565b60408051918252519081900360200190f35b3480156101bd57600080fd5b50610176600480360360608110156101d457600080fd5b50600160a060020a03813581169160208101359091169060400135610443565b34801561020057600080fd5b5061019f6004803603602081101561021757600080fd5b5035600160a060020a0316610547565b34801561023357600080fd5b5061023c610559565b6040805160ff9092168252519081900360200190f35b34801561025e57600080fd5b5061019f6004803603604081101561027557600080fd5b50600160a060020a0381358116916020013516610562565b34801561029957600080fd5b5061019f600480360360208110156102b057600080fd5b5035600160a060020a031661057f565b3480156102cc57600080fd5b506100c861059a565b3480156102e157600080fd5b50610176600480360360408110156102f857600080fd5b50600160a060020a0381351690602001356105f5565b34801561031a57600080fd5b5061019f6004803603604081101561033157600080fd5b50600160a060020a038135811691602001351661067f565b6003805460408051602060026001851615610100026000190190941693909304601f810184900484028201840190925281815292918301828280156103cf5780601f106103a4576101008083540402835291602001916103cf565b820191906000526020600020905b8154815290600101906020018083116103b257829003601f168201915b505050505081565b336000818152600260209081526040808320600160a060020a038716808552908352818420869055815186815291519394909390927f8c5be1e5ebec7d5bd14f71427d1e84f3dd0314c0f7b2291e5b200ac8c7c3b925928290030190a350600192915050565b60005481565b600160a060020a0383166000818152600260209081526040808320338452825280832054938352600190915281205490919083118015906104845750828110155b151561048f57600080fd5b600160a060020a03808516600090815260016020526040808220805487019055918716815220805484900390556000198110156104f157600160a060020a03851660009081526002602090815260408083203384529091529020805484900390555b83600160a060020a031685600160a060020a03167fddf252ad1be2c89b69c2b068fc378daa952ba7f163c4a11628f55a4df523b3ef856040518082815260200191505060405180910390a3506001949350505050565b60016020526000908152604090205481565b60045460ff1681565b600260209081526000928352604080842090915290825290205481565b600160a060020a031660009081526001602052604090205490565b6005805460408051602060026001851615610100026000190190941693909304601f810184900484028201840190925281815292918301828280156103cf5780601f106103a4576101008083540402835291602001916103cf565b3360009081526001602052604081205482111561061157600080fd5b33600081815260016020908152604080832080548790039055600160a060020a03871680845292819020805487019055805186815290519293927fddf252ad1be2c89b69c2b068fc378daa952ba7f163c4a11628f55a4df523b3ef929181900390910190a350600192915050565b600160a060020a0391821660009081526002602090815260408083209390941682529190915220549056fea165627a7a72305820bf98bac1860d24fef7ae343915c6dfc64cd9a412c62530168bc5c04435e2770b0029"
        
        Public Sub New()
            MyBase.New(DEFAULT_BYTECODE)
        End Sub
        
        Public Sub New(ByVal byteCode As String)
            MyBase.New(byteCode)
        End Sub
        

    
    End Class    
    
    Public Partial Class NameFunction
        Inherits NameFunctionBase
    End Class

        <[Function]("name", "string")>
    Public Class NameFunctionBase
        Inherits FunctionMessage
    

    
    End Class
    
    
    Public Partial Class ApproveFunction
        Inherits ApproveFunctionBase
    End Class

        <[Function]("approve", "bool")>
    Public Class ApproveFunctionBase
        Inherits FunctionMessage
    
        <[Parameter]("address", "_spender", 1)>
        Public Overridable Property [Spender] As String
        <[Parameter]("uint256", "_value", 2)>
        Public Overridable Property [Value] As BigInteger
    
    End Class
    
    
    Public Partial Class TotalSupplyFunction
        Inherits TotalSupplyFunctionBase
    End Class

        <[Function]("totalSupply", "uint256")>
    Public Class TotalSupplyFunctionBase
        Inherits FunctionMessage
    

    
    End Class
    
    
    Public Partial Class TransferFromFunction
        Inherits TransferFromFunctionBase
    End Class

        <[Function]("transferFrom", "bool")>
    Public Class TransferFromFunctionBase
        Inherits FunctionMessage
    
        <[Parameter]("address", "_from", 1)>
        Public Overridable Property [From] As String
        <[Parameter]("address", "_to", 2)>
        Public Overridable Property [To] As String
        <[Parameter]("uint256", "_value", 3)>
        Public Overridable Property [Value] As BigInteger
    
    End Class
    
    
    Public Partial Class BalancesFunction
        Inherits BalancesFunctionBase
    End Class

        <[Function]("balances", "uint256")>
    Public Class BalancesFunctionBase
        Inherits FunctionMessage
    
        <[Parameter]("address", "", 1)>
        Public Overridable Property [ReturnValue1] As String
    
    End Class
    
    
    Public Partial Class DecimalsFunction
        Inherits DecimalsFunctionBase
    End Class

        <[Function]("decimals", "uint8")>
    Public Class DecimalsFunctionBase
        Inherits FunctionMessage
    

    
    End Class
    
    
    Public Partial Class AllowedFunction
        Inherits AllowedFunctionBase
    End Class

        <[Function]("allowed", "uint256")>
    Public Class AllowedFunctionBase
        Inherits FunctionMessage
    
        <[Parameter]("address", "", 1)>
        Public Overridable Property [ReturnValue1] As String
        <[Parameter]("address", "", 2)>
        Public Overridable Property [ReturnValue2] As String
    
    End Class
    
    
    Public Partial Class BalanceOfFunction
        Inherits BalanceOfFunctionBase
    End Class

        <[Function]("balanceOf", "uint256")>
    Public Class BalanceOfFunctionBase
        Inherits FunctionMessage
    
        <[Parameter]("address", "_owner", 1)>
        Public Overridable Property [Owner] As String
    
    End Class
    
    
    Public Partial Class SymbolFunction
        Inherits SymbolFunctionBase
    End Class

        <[Function]("symbol", "string")>
    Public Class SymbolFunctionBase
        Inherits FunctionMessage
    

    
    End Class
    
    
    Public Partial Class TransferFunction
        Inherits TransferFunctionBase
    End Class

        <[Function]("transfer", "bool")>
    Public Class TransferFunctionBase
        Inherits FunctionMessage
    
        <[Parameter]("address", "_to", 1)>
        Public Overridable Property [To] As String
        <[Parameter]("uint256", "_value", 2)>
        Public Overridable Property [Value] As BigInteger
    
    End Class
    
    
    Public Partial Class AllowanceFunction
        Inherits AllowanceFunctionBase
    End Class

        <[Function]("allowance", "uint256")>
    Public Class AllowanceFunctionBase
        Inherits FunctionMessage
    
        <[Parameter]("address", "_owner", 1)>
        Public Overridable Property [Owner] As String
        <[Parameter]("address", "_spender", 2)>
        Public Overridable Property [Spender] As String
    
    End Class
    
    
    Public Partial Class TransferEventDTO
        Inherits TransferEventDTOBase
    End Class

    <[Event]("Transfer")>
    Public Class TransferEventDTOBase
        Implements IEventDTO
        
        <[Parameter]("address", "_from", 1, true)>
        Public Overridable Property [From] As String
        <[Parameter]("address", "_to", 2, true)>
        Public Overridable Property [To] As String
        <[Parameter]("uint256", "_value", 3, false)>
        Public Overridable Property [Value] As BigInteger
    
    End Class    
    
    Public Partial Class ApprovalEventDTO
        Inherits ApprovalEventDTOBase
    End Class

    <[Event]("Approval")>
    Public Class ApprovalEventDTOBase
        Implements IEventDTO
        
        <[Parameter]("address", "_owner", 1, true)>
        Public Overridable Property [Owner] As String
        <[Parameter]("address", "_spender", 2, true)>
        Public Overridable Property [Spender] As String
        <[Parameter]("uint256", "_value", 3, false)>
        Public Overridable Property [Value] As BigInteger
    
    End Class    
    
    Public Partial Class NameOutputDTO
        Inherits NameOutputDTOBase
    End Class

    <[FunctionOutput]>
    Public Class NameOutputDTOBase
        Implements IFunctionOutputDTO
        
        <[Parameter]("string", "", 1)>
        Public Overridable Property [ReturnValue1] As String
    
    End Class    
    
    
    
    Public Partial Class TotalSupplyOutputDTO
        Inherits TotalSupplyOutputDTOBase
    End Class

    <[FunctionOutput]>
    Public Class TotalSupplyOutputDTOBase
        Implements IFunctionOutputDTO
        
        <[Parameter]("uint256", "", 1)>
        Public Overridable Property [ReturnValue1] As BigInteger
    
    End Class    
    
    
    
    Public Partial Class BalancesOutputDTO
        Inherits BalancesOutputDTOBase
    End Class

    <[FunctionOutput]>
    Public Class BalancesOutputDTOBase
        Implements IFunctionOutputDTO
        
        <[Parameter]("uint256", "", 1)>
        Public Overridable Property [ReturnValue1] As BigInteger
    
    End Class    
    
    Public Partial Class DecimalsOutputDTO
        Inherits DecimalsOutputDTOBase
    End Class

    <[FunctionOutput]>
    Public Class DecimalsOutputDTOBase
        Implements IFunctionOutputDTO
        
        <[Parameter]("uint8", "", 1)>
        Public Overridable Property [ReturnValue1] As Byte
    
    End Class    
    
    Public Partial Class AllowedOutputDTO
        Inherits AllowedOutputDTOBase
    End Class

    <[FunctionOutput]>
    Public Class AllowedOutputDTOBase
        Implements IFunctionOutputDTO
        
        <[Parameter]("uint256", "", 1)>
        Public Overridable Property [ReturnValue1] As BigInteger
    
    End Class    
    
    Public Partial Class BalanceOfOutputDTO
        Inherits BalanceOfOutputDTOBase
    End Class

    <[FunctionOutput]>
    Public Class BalanceOfOutputDTOBase
        Implements IFunctionOutputDTO
        
        <[Parameter]("uint256", "balance", 1)>
        Public Overridable Property [Balance] As BigInteger
    
    End Class    
    
    Public Partial Class SymbolOutputDTO
        Inherits SymbolOutputDTOBase
    End Class

    <[FunctionOutput]>
    Public Class SymbolOutputDTOBase
        Implements IFunctionOutputDTO
        
        <[Parameter]("string", "", 1)>
        Public Overridable Property [ReturnValue1] As String
    
    End Class    
    
    
    
    Public Partial Class AllowanceOutputDTO
        Inherits AllowanceOutputDTOBase
    End Class

    <[FunctionOutput]>
    Public Class AllowanceOutputDTOBase
        Implements IFunctionOutputDTO
        
        <[Parameter]("uint256", "remaining", 1)>
        Public Overridable Property [Remaining] As BigInteger
    
    End Class
End Namespace
