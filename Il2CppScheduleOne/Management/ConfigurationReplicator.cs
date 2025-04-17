using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x02000381 RID: 897
	public class ConfigurationReplicator : NetworkBehaviour
	{
		// Token: 0x06004606 RID: 17926 RVA: 0x00158370 File Offset: 0x00156570
		// Note: this type is marked as 'beforefieldinit'.
		static ConfigurationReplicator()
		{
			Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "ConfigurationReplicator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr);
			ConfigurationReplicator.NativeFieldInfoPtr_Configuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, "Configuration");
			ConfigurationReplicator.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Management.ConfigurationReplicatorAssembly-CSharp.dll_Excuted");
			ConfigurationReplicator.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Management.ConfigurationReplicatorAssembly-CSharp.dll_Excuted");
			ConfigurationReplicator.NativeMethodInfoPtr_ReplicateField_Public_Void_ConfigField_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671904);
			ConfigurationReplicator.NativeMethodInfoPtr_SendItemField_Private_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671905);
			ConfigurationReplicator.NativeMethodInfoPtr_ReceiveItemField_Private_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671906);
			ConfigurationReplicator.NativeMethodInfoPtr_SendNPCField_Private_Void_Int32_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671907);
			ConfigurationReplicator.NativeMethodInfoPtr_ReceiveNPCField_Private_Void_Int32_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671908);
			ConfigurationReplicator.NativeMethodInfoPtr_SendObjectField_Private_Void_Int32_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671909);
			ConfigurationReplicator.NativeMethodInfoPtr_ReceiveObjectField_Private_Void_Int32_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671910);
			ConfigurationReplicator.NativeMethodInfoPtr_SendObjectListField_Private_Void_Int32_List_1_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671911);
			ConfigurationReplicator.NativeMethodInfoPtr_ReceiveObjectListField_Private_Void_Int32_List_1_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671912);
			ConfigurationReplicator.NativeMethodInfoPtr_SendRecipeField_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671913);
			ConfigurationReplicator.NativeMethodInfoPtr_ReceiveRecipeField_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671914);
			ConfigurationReplicator.NativeMethodInfoPtr_SendNumberField_Private_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671915);
			ConfigurationReplicator.NativeMethodInfoPtr_ReceiveNumberField_Private_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671916);
			ConfigurationReplicator.NativeMethodInfoPtr_SendRouteListField_Private_Void_Int32_Il2CppReferenceArray_1_AdvancedTransitRouteData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671917);
			ConfigurationReplicator.NativeMethodInfoPtr_ReceiveRouteListField_Private_Void_Int32_Il2CppReferenceArray_1_AdvancedTransitRouteData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671918);
			ConfigurationReplicator.NativeMethodInfoPtr_SendQualityField_Private_Void_Int32_EQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671919);
			ConfigurationReplicator.NativeMethodInfoPtr_ReceiveQualityField_Private_Void_Int32_EQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671920);
			ConfigurationReplicator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671921);
			ConfigurationReplicator.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671922);
			ConfigurationReplicator.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671923);
			ConfigurationReplicator.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671924);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Server_SendItemField_2801973956_Private_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671925);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___SendItemField_2801973956_Private_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671926);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Server_SendItemField_2801973956_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671927);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveItemField_2801973956_Private_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671928);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___ReceiveItemField_2801973956_Private_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671929);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Observers_ReceiveItemField_2801973956_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671930);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Server_SendNPCField_1687693739_Private_Void_Int32_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671931);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___SendNPCField_1687693739_Private_Void_Int32_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671932);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Server_SendNPCField_1687693739_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671933);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveNPCField_1687693739_Private_Void_Int32_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671934);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___ReceiveNPCField_1687693739_Private_Void_Int32_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671935);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Observers_ReceiveNPCField_1687693739_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671936);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Server_SendObjectField_1687693739_Private_Void_Int32_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671937);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___SendObjectField_1687693739_Private_Void_Int32_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671938);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Server_SendObjectField_1687693739_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671939);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveObjectField_1687693739_Private_Void_Int32_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671940);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___ReceiveObjectField_1687693739_Private_Void_Int32_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671941);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Observers_ReceiveObjectField_1687693739_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671942);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Server_SendObjectListField_690244341_Private_Void_Int32_List_1_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671943);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___SendObjectListField_690244341_Private_Void_Int32_List_1_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671944);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Server_SendObjectListField_690244341_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671945);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveObjectListField_690244341_Private_Void_Int32_List_1_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671946);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___ReceiveObjectListField_690244341_Private_Void_Int32_List_1_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671947);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Observers_ReceiveObjectListField_690244341_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671948);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Server_SendRecipeField_1692629761_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671949);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___SendRecipeField_1692629761_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671950);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Server_SendRecipeField_1692629761_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671951);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveRecipeField_1692629761_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671952);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___ReceiveRecipeField_1692629761_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671953);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Observers_ReceiveRecipeField_1692629761_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671954);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Server_SendNumberField_1293284375_Private_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671955);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___SendNumberField_1293284375_Private_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671956);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Server_SendNumberField_1293284375_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671957);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveNumberField_1293284375_Private_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671958);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___ReceiveNumberField_1293284375_Private_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671959);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Observers_ReceiveNumberField_1293284375_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671960);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Server_SendRouteListField_3226448297_Private_Void_Int32_Il2CppReferenceArray_1_AdvancedTransitRouteData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671961);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___SendRouteListField_3226448297_Private_Void_Int32_Il2CppReferenceArray_1_AdvancedTransitRouteData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671962);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Server_SendRouteListField_3226448297_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671963);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveRouteListField_3226448297_Private_Void_Int32_Il2CppReferenceArray_1_AdvancedTransitRouteData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671964);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___ReceiveRouteListField_3226448297_Private_Void_Int32_Il2CppReferenceArray_1_AdvancedTransitRouteData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671965);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Observers_ReceiveRouteListField_3226448297_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671966);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Server_SendQualityField_3536682170_Private_Void_Int32_EQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671967);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___SendQualityField_3536682170_Private_Void_Int32_EQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671968);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Server_SendQualityField_3536682170_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671969);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveQualityField_3536682170_Private_Void_Int32_EQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671970);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___ReceiveQualityField_3536682170_Private_Void_Int32_EQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671971);
			ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Observers_ReceiveQualityField_3536682170_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671972);
			ConfigurationReplicator.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, 100671973);
		}

		// Token: 0x06004607 RID: 17927 RVA: 0x00158954 File Offset: 0x00156B54
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 158107, RefRangeEnd = 158119, XrefRangeStart = 157889, XrefRangeEnd = 158107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReplicateField(ConfigField field, NetworkConnection conn = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(field);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_ReplicateField_Public_Void_ConfigField_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004608 RID: 17928 RVA: 0x001589A8 File Offset: 0x00156BA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158119, XrefRangeEnd = 158140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendItemField(int fieldIndex, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_SendItemField_Private_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004609 RID: 17929 RVA: 0x001589F8 File Offset: 0x00156BF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158140, XrefRangeEnd = 158161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveItemField(int fieldIndex, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_ReceiveItemField_Private_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600460A RID: 17930 RVA: 0x00158A48 File Offset: 0x00156C48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158161, XrefRangeEnd = 158182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendNPCField(int fieldIndex, NetworkObject npcObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(npcObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_SendNPCField_Private_Void_Int32_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600460B RID: 17931 RVA: 0x00158A98 File Offset: 0x00156C98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158182, XrefRangeEnd = 158203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveNPCField(int fieldIndex, NetworkObject npcObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(npcObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_ReceiveNPCField_Private_Void_Int32_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600460C RID: 17932 RVA: 0x00158AE8 File Offset: 0x00156CE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158203, XrefRangeEnd = 158224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendObjectField(int fieldIndex, NetworkObject obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_SendObjectField_Private_Void_Int32_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600460D RID: 17933 RVA: 0x00158B38 File Offset: 0x00156D38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158224, XrefRangeEnd = 158245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveObjectField(int fieldIndex, NetworkObject obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_ReceiveObjectField_Private_Void_Int32_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600460E RID: 17934 RVA: 0x00158B88 File Offset: 0x00156D88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158245, XrefRangeEnd = 158266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendObjectListField(int fieldIndex, List<NetworkObject> objects)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objects);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_SendObjectListField_Private_Void_Int32_List_1_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600460F RID: 17935 RVA: 0x00158BD8 File Offset: 0x00156DD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158266, XrefRangeEnd = 158287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveObjectListField(int fieldIndex, List<NetworkObject> objects)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objects);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_ReceiveObjectListField_Private_Void_Int32_List_1_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004610 RID: 17936 RVA: 0x00158C28 File Offset: 0x00156E28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158287, XrefRangeEnd = 158309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendRecipeField(int fieldIndex, int recipeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref recipeIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_SendRecipeField_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004611 RID: 17937 RVA: 0x00158C74 File Offset: 0x00156E74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158309, XrefRangeEnd = 158331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveRecipeField(int fieldIndex, int recipeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref recipeIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_ReceiveRecipeField_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004612 RID: 17938 RVA: 0x00158CC0 File Offset: 0x00156EC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158331, XrefRangeEnd = 158352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendNumberField(int fieldIndex, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_SendNumberField_Private_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004613 RID: 17939 RVA: 0x00158D0C File Offset: 0x00156F0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158352, XrefRangeEnd = 158373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveNumberField(int fieldIndex, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_ReceiveNumberField_Private_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004614 RID: 17940 RVA: 0x00158D58 File Offset: 0x00156F58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158373, XrefRangeEnd = 158394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendRouteListField(int fieldIndex, Il2CppReferenceArray<AdvancedTransitRouteData> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_SendRouteListField_Private_Void_Int32_Il2CppReferenceArray_1_AdvancedTransitRouteData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004615 RID: 17941 RVA: 0x00158DA8 File Offset: 0x00156FA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158394, XrefRangeEnd = 158415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveRouteListField(int fieldIndex, Il2CppReferenceArray<AdvancedTransitRouteData> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_ReceiveRouteListField_Private_Void_Int32_Il2CppReferenceArray_1_AdvancedTransitRouteData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004616 RID: 17942 RVA: 0x00158DF8 File Offset: 0x00156FF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158415, XrefRangeEnd = 158436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendQualityField(int fieldIndex, EQuality quality)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quality;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_SendQualityField_Private_Void_Int32_EQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004617 RID: 17943 RVA: 0x00158E44 File Offset: 0x00157044
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158436, XrefRangeEnd = 158457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveQualityField(int fieldIndex, EQuality value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_ReceiveQualityField_Private_Void_Int32_EQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004618 RID: 17944 RVA: 0x00158E90 File Offset: 0x00157090
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 134800, RefRangeEnd = 134822, XrefRangeStart = 134800, XrefRangeEnd = 134822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfigurationReplicator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004619 RID: 17945 RVA: 0x00158ECC File Offset: 0x001570CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158457, XrefRangeEnd = 158555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConfigurationReplicator.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600461A RID: 17946 RVA: 0x00158F08 File Offset: 0x00157108
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConfigurationReplicator.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600461B RID: 17947 RVA: 0x00158F44 File Offset: 0x00157144
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConfigurationReplicator.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600461C RID: 17948 RVA: 0x00158F80 File Offset: 0x00157180
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendItemField_2801973956(int fieldIndex, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Server_SendItemField_2801973956_Private_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600461D RID: 17949 RVA: 0x00158FD0 File Offset: 0x001571D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendItemField_2801973956(int fieldIndex, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___SendItemField_2801973956_Private_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600461E RID: 17950 RVA: 0x00159020 File Offset: 0x00157220
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158555, XrefRangeEnd = 158571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendItemField_2801973956(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Server_SendItemField_2801973956_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600461F RID: 17951 RVA: 0x00159084 File Offset: 0x00157284
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveItemField_2801973956(int fieldIndex, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveItemField_2801973956_Private_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004620 RID: 17952 RVA: 0x001590D4 File Offset: 0x001572D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158571, XrefRangeEnd = 158589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceiveItemField_2801973956(int fieldIndex, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___ReceiveItemField_2801973956_Private_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004621 RID: 17953 RVA: 0x00159124 File Offset: 0x00157324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158589, XrefRangeEnd = 158611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveItemField_2801973956(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Observers_ReceiveItemField_2801973956_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004622 RID: 17954 RVA: 0x00159174 File Offset: 0x00157374
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendNPCField_1687693739(int fieldIndex, NetworkObject npcObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(npcObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Server_SendNPCField_1687693739_Private_Void_Int32_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004623 RID: 17955 RVA: 0x001591C4 File Offset: 0x001573C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendNPCField_1687693739(int fieldIndex, NetworkObject npcObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(npcObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___SendNPCField_1687693739_Private_Void_Int32_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004624 RID: 17956 RVA: 0x00159214 File Offset: 0x00157414
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158611, XrefRangeEnd = 158627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendNPCField_1687693739(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Server_SendNPCField_1687693739_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004625 RID: 17957 RVA: 0x00159278 File Offset: 0x00157478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveNPCField_1687693739(int fieldIndex, NetworkObject npcObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(npcObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveNPCField_1687693739_Private_Void_Int32_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004626 RID: 17958 RVA: 0x001592C8 File Offset: 0x001574C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 158652, RefRangeEnd = 158653, XrefRangeStart = 158627, XrefRangeEnd = 158652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceiveNPCField_1687693739(int fieldIndex, NetworkObject npcObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(npcObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___ReceiveNPCField_1687693739_Private_Void_Int32_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004627 RID: 17959 RVA: 0x00159318 File Offset: 0x00157518
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158653, XrefRangeEnd = 158658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveNPCField_1687693739(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Observers_ReceiveNPCField_1687693739_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004628 RID: 17960 RVA: 0x00159368 File Offset: 0x00157568
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendObjectField_1687693739(int fieldIndex, NetworkObject obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Server_SendObjectField_1687693739_Private_Void_Int32_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004629 RID: 17961 RVA: 0x001593B8 File Offset: 0x001575B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendObjectField_1687693739(int fieldIndex, NetworkObject obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___SendObjectField_1687693739_Private_Void_Int32_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600462A RID: 17962 RVA: 0x00159408 File Offset: 0x00157608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158658, XrefRangeEnd = 158674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendObjectField_1687693739(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Server_SendObjectField_1687693739_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600462B RID: 17963 RVA: 0x0015946C File Offset: 0x0015766C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveObjectField_1687693739(int fieldIndex, NetworkObject obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveObjectField_1687693739_Private_Void_Int32_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600462C RID: 17964 RVA: 0x001594BC File Offset: 0x001576BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158674, XrefRangeEnd = 158693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceiveObjectField_1687693739(int fieldIndex, NetworkObject obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___ReceiveObjectField_1687693739_Private_Void_Int32_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600462D RID: 17965 RVA: 0x0015950C File Offset: 0x0015770C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158693, XrefRangeEnd = 158715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveObjectField_1687693739(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Observers_ReceiveObjectField_1687693739_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600462E RID: 17966 RVA: 0x0015955C File Offset: 0x0015775C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendObjectListField_690244341(int fieldIndex, List<NetworkObject> objects)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objects);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Server_SendObjectListField_690244341_Private_Void_Int32_List_1_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600462F RID: 17967 RVA: 0x001595AC File Offset: 0x001577AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendObjectListField_690244341(int fieldIndex, List<NetworkObject> objects)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objects);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___SendObjectListField_690244341_Private_Void_Int32_List_1_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004630 RID: 17968 RVA: 0x001595FC File Offset: 0x001577FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158715, XrefRangeEnd = 158731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendObjectListField_690244341(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Server_SendObjectListField_690244341_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004631 RID: 17969 RVA: 0x00159660 File Offset: 0x00157860
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveObjectListField_690244341(int fieldIndex, List<NetworkObject> objects)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objects);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveObjectListField_690244341_Private_Void_Int32_List_1_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004632 RID: 17970 RVA: 0x001596B0 File Offset: 0x001578B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 158760, RefRangeEnd = 158761, XrefRangeStart = 158731, XrefRangeEnd = 158760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceiveObjectListField_690244341(int fieldIndex, List<NetworkObject> objects)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objects);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___ReceiveObjectListField_690244341_Private_Void_Int32_List_1_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004633 RID: 17971 RVA: 0x00159700 File Offset: 0x00157900
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158761, XrefRangeEnd = 158766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveObjectListField_690244341(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Observers_ReceiveObjectListField_690244341_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004634 RID: 17972 RVA: 0x00159750 File Offset: 0x00157950
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendRecipeField_1692629761(int fieldIndex, int recipeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref recipeIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Server_SendRecipeField_1692629761_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004635 RID: 17973 RVA: 0x0015979C File Offset: 0x0015799C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendRecipeField_1692629761(int fieldIndex, int recipeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref recipeIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___SendRecipeField_1692629761_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004636 RID: 17974 RVA: 0x001597E8 File Offset: 0x001579E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158766, XrefRangeEnd = 158784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendRecipeField_1692629761(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Server_SendRecipeField_1692629761_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004637 RID: 17975 RVA: 0x0015984C File Offset: 0x00157A4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveRecipeField_1692629761(int fieldIndex, int recipeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref recipeIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveRecipeField_1692629761_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004638 RID: 17976 RVA: 0x00159898 File Offset: 0x00157A98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158784, XrefRangeEnd = 158799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceiveRecipeField_1692629761(int fieldIndex, int recipeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref recipeIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___ReceiveRecipeField_1692629761_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004639 RID: 17977 RVA: 0x001598E4 File Offset: 0x00157AE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158799, XrefRangeEnd = 158819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveRecipeField_1692629761(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Observers_ReceiveRecipeField_1692629761_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600463A RID: 17978 RVA: 0x00159934 File Offset: 0x00157B34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendNumberField_1293284375(int fieldIndex, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Server_SendNumberField_1293284375_Private_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600463B RID: 17979 RVA: 0x00159980 File Offset: 0x00157B80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendNumberField_1293284375(int fieldIndex, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___SendNumberField_1293284375_Private_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600463C RID: 17980 RVA: 0x001599CC File Offset: 0x00157BCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158819, XrefRangeEnd = 158835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendNumberField_1293284375(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Server_SendNumberField_1293284375_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600463D RID: 17981 RVA: 0x00159A30 File Offset: 0x00157C30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveNumberField_1293284375(int fieldIndex, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveNumberField_1293284375_Private_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600463E RID: 17982 RVA: 0x00159A7C File Offset: 0x00157C7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158835, XrefRangeEnd = 158843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceiveNumberField_1293284375(int fieldIndex, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___ReceiveNumberField_1293284375_Private_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600463F RID: 17983 RVA: 0x00159AC8 File Offset: 0x00157CC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158843, XrefRangeEnd = 158855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveNumberField_1293284375(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Observers_ReceiveNumberField_1293284375_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004640 RID: 17984 RVA: 0x00159B18 File Offset: 0x00157D18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendRouteListField_3226448297(int fieldIndex, Il2CppReferenceArray<AdvancedTransitRouteData> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Server_SendRouteListField_3226448297_Private_Void_Int32_Il2CppReferenceArray_1_AdvancedTransitRouteData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004641 RID: 17985 RVA: 0x00159B68 File Offset: 0x00157D68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendRouteListField_3226448297(int fieldIndex, Il2CppReferenceArray<AdvancedTransitRouteData> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___SendRouteListField_3226448297_Private_Void_Int32_Il2CppReferenceArray_1_AdvancedTransitRouteData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004642 RID: 17986 RVA: 0x00159BB8 File Offset: 0x00157DB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158855, XrefRangeEnd = 158871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendRouteListField_3226448297(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Server_SendRouteListField_3226448297_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004643 RID: 17987 RVA: 0x00159C1C File Offset: 0x00157E1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveRouteListField_3226448297(int fieldIndex, Il2CppReferenceArray<AdvancedTransitRouteData> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveRouteListField_3226448297_Private_Void_Int32_Il2CppReferenceArray_1_AdvancedTransitRouteData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004644 RID: 17988 RVA: 0x00159C6C File Offset: 0x00157E6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 158904, RefRangeEnd = 158905, XrefRangeStart = 158871, XrefRangeEnd = 158904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceiveRouteListField_3226448297(int fieldIndex, Il2CppReferenceArray<AdvancedTransitRouteData> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___ReceiveRouteListField_3226448297_Private_Void_Int32_Il2CppReferenceArray_1_AdvancedTransitRouteData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004645 RID: 17989 RVA: 0x00159CBC File Offset: 0x00157EBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158905, XrefRangeEnd = 158910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveRouteListField_3226448297(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Observers_ReceiveRouteListField_3226448297_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004646 RID: 17990 RVA: 0x00159D0C File Offset: 0x00157F0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendQualityField_3536682170(int fieldIndex, EQuality quality)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quality;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Server_SendQualityField_3536682170_Private_Void_Int32_EQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004647 RID: 17991 RVA: 0x00159D58 File Offset: 0x00157F58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendQualityField_3536682170(int fieldIndex, EQuality quality)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quality;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___SendQualityField_3536682170_Private_Void_Int32_EQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004648 RID: 17992 RVA: 0x00159DA4 File Offset: 0x00157FA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158910, XrefRangeEnd = 158926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendQualityField_3536682170(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Server_SendQualityField_3536682170_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004649 RID: 17993 RVA: 0x00159E08 File Offset: 0x00158008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveQualityField_3536682170(int fieldIndex, EQuality value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveQualityField_3536682170_Private_Void_Int32_EQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600464A RID: 17994 RVA: 0x00159E54 File Offset: 0x00158054
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158926, XrefRangeEnd = 158934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceiveQualityField_3536682170(int fieldIndex, EQuality value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fieldIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcLogic___ReceiveQualityField_3536682170_Private_Void_Int32_EQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600464B RID: 17995 RVA: 0x00159EA0 File Offset: 0x001580A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158934, XrefRangeEnd = 158946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveQualityField_3536682170(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.NativeMethodInfoPtr_RpcReader___Observers_ReceiveQualityField_3536682170_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600464C RID: 17996 RVA: 0x00159EF0 File Offset: 0x001580F0
		[CallerCount(0)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConfigurationReplicator.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600464D RID: 17997 RVA: 0x000221A5 File Offset: 0x000203A5
		public ConfigurationReplicator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700151C RID: 5404
		// (get) Token: 0x0600464E RID: 17998 RVA: 0x00159F2C File Offset: 0x0015812C
		// (set) Token: 0x0600464F RID: 17999 RVA: 0x000221AE File Offset: 0x000203AE
		public unsafe EntityConfiguration Configuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurationReplicator.NativeFieldInfoPtr_Configuration);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityConfiguration>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurationReplicator.NativeFieldInfoPtr_Configuration), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700151D RID: 5405
		// (get) Token: 0x06004650 RID: 18000 RVA: 0x00159F5C File Offset: 0x0015815C
		// (set) Token: 0x06004651 RID: 18001 RVA: 0x000221CD File Offset: 0x000203CD
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurationReplicator.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurationReplicator.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x1700151E RID: 5406
		// (get) Token: 0x06004652 RID: 18002 RVA: 0x00159F84 File Offset: 0x00158184
		// (set) Token: 0x06004653 RID: 18003 RVA: 0x000221E8 File Offset: 0x000203E8
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurationReplicator.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurationReplicator.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04002EFF RID: 12031
		private static readonly IntPtr NativeFieldInfoPtr_Configuration;

		// Token: 0x04002F00 RID: 12032
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04002F01 RID: 12033
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04002F02 RID: 12034
		private static readonly IntPtr NativeMethodInfoPtr_ReplicateField_Public_Void_ConfigField_NetworkConnection_0;

		// Token: 0x04002F03 RID: 12035
		private static readonly IntPtr NativeMethodInfoPtr_SendItemField_Private_Void_Int32_String_0;

		// Token: 0x04002F04 RID: 12036
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveItemField_Private_Void_Int32_String_0;

		// Token: 0x04002F05 RID: 12037
		private static readonly IntPtr NativeMethodInfoPtr_SendNPCField_Private_Void_Int32_NetworkObject_0;

		// Token: 0x04002F06 RID: 12038
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveNPCField_Private_Void_Int32_NetworkObject_0;

		// Token: 0x04002F07 RID: 12039
		private static readonly IntPtr NativeMethodInfoPtr_SendObjectField_Private_Void_Int32_NetworkObject_0;

		// Token: 0x04002F08 RID: 12040
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveObjectField_Private_Void_Int32_NetworkObject_0;

		// Token: 0x04002F09 RID: 12041
		private static readonly IntPtr NativeMethodInfoPtr_SendObjectListField_Private_Void_Int32_List_1_NetworkObject_0;

		// Token: 0x04002F0A RID: 12042
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveObjectListField_Private_Void_Int32_List_1_NetworkObject_0;

		// Token: 0x04002F0B RID: 12043
		private static readonly IntPtr NativeMethodInfoPtr_SendRecipeField_Private_Void_Int32_Int32_0;

		// Token: 0x04002F0C RID: 12044
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveRecipeField_Private_Void_Int32_Int32_0;

		// Token: 0x04002F0D RID: 12045
		private static readonly IntPtr NativeMethodInfoPtr_SendNumberField_Private_Void_Int32_Single_0;

		// Token: 0x04002F0E RID: 12046
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveNumberField_Private_Void_Int32_Single_0;

		// Token: 0x04002F0F RID: 12047
		private static readonly IntPtr NativeMethodInfoPtr_SendRouteListField_Private_Void_Int32_Il2CppReferenceArray_1_AdvancedTransitRouteData_0;

		// Token: 0x04002F10 RID: 12048
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveRouteListField_Private_Void_Int32_Il2CppReferenceArray_1_AdvancedTransitRouteData_0;

		// Token: 0x04002F11 RID: 12049
		private static readonly IntPtr NativeMethodInfoPtr_SendQualityField_Private_Void_Int32_EQuality_0;

		// Token: 0x04002F12 RID: 12050
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveQualityField_Private_Void_Int32_EQuality_0;

		// Token: 0x04002F13 RID: 12051
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002F14 RID: 12052
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04002F15 RID: 12053
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04002F16 RID: 12054
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04002F17 RID: 12055
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendItemField_2801973956_Private_Void_Int32_String_0;

		// Token: 0x04002F18 RID: 12056
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendItemField_2801973956_Private_Void_Int32_String_0;

		// Token: 0x04002F19 RID: 12057
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendItemField_2801973956_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04002F1A RID: 12058
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveItemField_2801973956_Private_Void_Int32_String_0;

		// Token: 0x04002F1B RID: 12059
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveItemField_2801973956_Private_Void_Int32_String_0;

		// Token: 0x04002F1C RID: 12060
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveItemField_2801973956_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002F1D RID: 12061
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendNPCField_1687693739_Private_Void_Int32_NetworkObject_0;

		// Token: 0x04002F1E RID: 12062
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendNPCField_1687693739_Private_Void_Int32_NetworkObject_0;

		// Token: 0x04002F1F RID: 12063
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendNPCField_1687693739_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04002F20 RID: 12064
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveNPCField_1687693739_Private_Void_Int32_NetworkObject_0;

		// Token: 0x04002F21 RID: 12065
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveNPCField_1687693739_Private_Void_Int32_NetworkObject_0;

		// Token: 0x04002F22 RID: 12066
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveNPCField_1687693739_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002F23 RID: 12067
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendObjectField_1687693739_Private_Void_Int32_NetworkObject_0;

		// Token: 0x04002F24 RID: 12068
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendObjectField_1687693739_Private_Void_Int32_NetworkObject_0;

		// Token: 0x04002F25 RID: 12069
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendObjectField_1687693739_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04002F26 RID: 12070
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveObjectField_1687693739_Private_Void_Int32_NetworkObject_0;

		// Token: 0x04002F27 RID: 12071
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveObjectField_1687693739_Private_Void_Int32_NetworkObject_0;

		// Token: 0x04002F28 RID: 12072
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveObjectField_1687693739_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002F29 RID: 12073
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendObjectListField_690244341_Private_Void_Int32_List_1_NetworkObject_0;

		// Token: 0x04002F2A RID: 12074
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendObjectListField_690244341_Private_Void_Int32_List_1_NetworkObject_0;

		// Token: 0x04002F2B RID: 12075
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendObjectListField_690244341_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04002F2C RID: 12076
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveObjectListField_690244341_Private_Void_Int32_List_1_NetworkObject_0;

		// Token: 0x04002F2D RID: 12077
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveObjectListField_690244341_Private_Void_Int32_List_1_NetworkObject_0;

		// Token: 0x04002F2E RID: 12078
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveObjectListField_690244341_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002F2F RID: 12079
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendRecipeField_1692629761_Private_Void_Int32_Int32_0;

		// Token: 0x04002F30 RID: 12080
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendRecipeField_1692629761_Private_Void_Int32_Int32_0;

		// Token: 0x04002F31 RID: 12081
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendRecipeField_1692629761_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04002F32 RID: 12082
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveRecipeField_1692629761_Private_Void_Int32_Int32_0;

		// Token: 0x04002F33 RID: 12083
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveRecipeField_1692629761_Private_Void_Int32_Int32_0;

		// Token: 0x04002F34 RID: 12084
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveRecipeField_1692629761_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002F35 RID: 12085
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendNumberField_1293284375_Private_Void_Int32_Single_0;

		// Token: 0x04002F36 RID: 12086
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendNumberField_1293284375_Private_Void_Int32_Single_0;

		// Token: 0x04002F37 RID: 12087
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendNumberField_1293284375_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04002F38 RID: 12088
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveNumberField_1293284375_Private_Void_Int32_Single_0;

		// Token: 0x04002F39 RID: 12089
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveNumberField_1293284375_Private_Void_Int32_Single_0;

		// Token: 0x04002F3A RID: 12090
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveNumberField_1293284375_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002F3B RID: 12091
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendRouteListField_3226448297_Private_Void_Int32_Il2CppReferenceArray_1_AdvancedTransitRouteData_0;

		// Token: 0x04002F3C RID: 12092
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendRouteListField_3226448297_Private_Void_Int32_Il2CppReferenceArray_1_AdvancedTransitRouteData_0;

		// Token: 0x04002F3D RID: 12093
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendRouteListField_3226448297_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04002F3E RID: 12094
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveRouteListField_3226448297_Private_Void_Int32_Il2CppReferenceArray_1_AdvancedTransitRouteData_0;

		// Token: 0x04002F3F RID: 12095
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveRouteListField_3226448297_Private_Void_Int32_Il2CppReferenceArray_1_AdvancedTransitRouteData_0;

		// Token: 0x04002F40 RID: 12096
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveRouteListField_3226448297_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002F41 RID: 12097
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendQualityField_3536682170_Private_Void_Int32_EQuality_0;

		// Token: 0x04002F42 RID: 12098
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendQualityField_3536682170_Private_Void_Int32_EQuality_0;

		// Token: 0x04002F43 RID: 12099
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendQualityField_3536682170_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04002F44 RID: 12100
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveQualityField_3536682170_Private_Void_Int32_EQuality_0;

		// Token: 0x04002F45 RID: 12101
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveQualityField_3536682170_Private_Void_Int32_EQuality_0;

		// Token: 0x04002F46 RID: 12102
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveQualityField_3536682170_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002F47 RID: 12103
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x02000975 RID: 2421
		[ObfuscatedName("ScheduleOne.Management.ConfigurationReplicator+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600C9AA RID: 51626 RVA: 0x0030CEB0 File Offset: 0x0030B0B0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ConfigurationReplicator.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConfigurationReplicator>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigurationReplicator.__c>.NativeClassPtr);
				ConfigurationReplicator.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurationReplicator.__c>.NativeClassPtr, "<>9");
				ConfigurationReplicator.__c.NativeFieldInfoPtr___9__1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurationReplicator.__c>.NativeClassPtr, "<>9__1_0");
				ConfigurationReplicator.__c.NativeFieldInfoPtr___9__15_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurationReplicator.__c>.NativeClassPtr, "<>9__15_0");
				ConfigurationReplicator.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator.__c>.NativeClassPtr, 100671975);
				ConfigurationReplicator.__c.NativeMethodInfoPtr__ReplicateField_b__1_0_Internal_AdvancedTransitRouteData_AdvancedTransitRoute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator.__c>.NativeClassPtr, 100671976);
				ConfigurationReplicator.__c.NativeMethodInfoPtr__ReceiveRouteListField_b__15_0_Internal_AdvancedTransitRoute_AdvancedTransitRouteData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationReplicator.__c>.NativeClassPtr, 100671977);
			}

			// Token: 0x0600C9AB RID: 51627 RVA: 0x0030CF54 File Offset: 0x0030B154
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfigurationReplicator.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C9AC RID: 51628 RVA: 0x0030CF90 File Offset: 0x0030B190
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157883, XrefRangeEnd = 157885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AdvancedTransitRouteData _ReplicateField_b__1_0(AdvancedTransitRoute x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.__c.NativeMethodInfoPtr__ReplicateField_b__1_0_Internal_AdvancedTransitRouteData_AdvancedTransitRoute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AdvancedTransitRouteData>(intPtr3) : null;
			}

			// Token: 0x0600C9AD RID: 51629 RVA: 0x0030CFE0 File Offset: 0x0030B1E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157885, XrefRangeEnd = 157889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AdvancedTransitRoute _ReceiveRouteListField_b__15_0(AdvancedTransitRouteData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationReplicator.__c.NativeMethodInfoPtr__ReceiveRouteListField_b__15_0_Internal_AdvancedTransitRoute_AdvancedTransitRouteData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AdvancedTransitRoute>(intPtr3) : null;
			}

			// Token: 0x0600C9AE RID: 51630 RVA: 0x00062117 File Offset: 0x00060317
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003EE0 RID: 16096
			// (get) Token: 0x0600C9AF RID: 51631 RVA: 0x0030D030 File Offset: 0x0030B230
			// (set) Token: 0x0600C9B0 RID: 51632 RVA: 0x00062120 File Offset: 0x00060320
			public unsafe static ConfigurationReplicator.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ConfigurationReplicator.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigurationReplicator.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ConfigurationReplicator.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003EE1 RID: 16097
			// (get) Token: 0x0600C9B1 RID: 51633 RVA: 0x0030D058 File Offset: 0x0030B258
			// (set) Token: 0x0600C9B2 RID: 51634 RVA: 0x00062132 File Offset: 0x00060332
			public unsafe static Func<AdvancedTransitRoute, AdvancedTransitRouteData> __9__1_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ConfigurationReplicator.__c.NativeFieldInfoPtr___9__1_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<AdvancedTransitRoute, AdvancedTransitRouteData>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ConfigurationReplicator.__c.NativeFieldInfoPtr___9__1_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003EE2 RID: 16098
			// (get) Token: 0x0600C9B3 RID: 51635 RVA: 0x0030D080 File Offset: 0x0030B280
			// (set) Token: 0x0600C9B4 RID: 51636 RVA: 0x00062144 File Offset: 0x00060344
			public unsafe static Func<AdvancedTransitRouteData, AdvancedTransitRoute> __9__15_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ConfigurationReplicator.__c.NativeFieldInfoPtr___9__15_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<AdvancedTransitRouteData, AdvancedTransitRoute>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ConfigurationReplicator.__c.NativeFieldInfoPtr___9__15_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008877 RID: 34935
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008878 RID: 34936
			private static readonly IntPtr NativeFieldInfoPtr___9__1_0;

			// Token: 0x04008879 RID: 34937
			private static readonly IntPtr NativeFieldInfoPtr___9__15_0;

			// Token: 0x0400887A RID: 34938
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400887B RID: 34939
			private static readonly IntPtr NativeMethodInfoPtr__ReplicateField_b__1_0_Internal_AdvancedTransitRouteData_AdvancedTransitRoute_0;

			// Token: 0x0400887C RID: 34940
			private static readonly IntPtr NativeMethodInfoPtr__ReceiveRouteListField_b__15_0_Internal_AdvancedTransitRoute_AdvancedTransitRouteData_0;
		}
	}
}
