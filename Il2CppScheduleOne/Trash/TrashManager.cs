using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Persistence;
using Il2CppScheduleOne.Persistence.Loaders;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Trash
{
	// Token: 0x02000523 RID: 1315
	public class TrashManager : NetworkSingleton<TrashManager>
	{
		// Token: 0x06007568 RID: 30056 RVA: 0x001FEF84 File Offset: 0x001FD184
		// Note: this type is marked as 'beforefieldinit'.
		static TrashManager()
		{
			Il2CppClassPointerStore<TrashManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Trash", "TrashManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashManager>.NativeClassPtr);
			TrashManager.NativeFieldInfoPtr_TRASH_ITEM_LIMIT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, "TRASH_ITEM_LIMIT");
			TrashManager.NativeFieldInfoPtr_TrashPrefabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, "TrashPrefabs");
			TrashManager.NativeFieldInfoPtr_TrashBagPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, "TrashBagPrefab");
			TrashManager.NativeFieldInfoPtr_GenerateableTrashItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, "GenerateableTrashItems");
			TrashManager.NativeFieldInfoPtr_trashItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, "trashItems");
			TrashManager.NativeFieldInfoPtr_TrashForceMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, "TrashForceMultiplier");
			TrashManager.NativeFieldInfoPtr_loader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, "loader");
			TrashManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, "<LocalExtraFiles>k__BackingField");
			TrashManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, "<LocalExtraFolders>k__BackingField");
			TrashManager.NativeFieldInfoPtr__HasChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, "<HasChanged>k__BackingField");
			TrashManager.NativeFieldInfoPtr_writtenItemFiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, "writtenItemFiles");
			TrashManager.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Trash.TrashManagerAssembly-CSharp.dll_Excuted");
			TrashManager.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Trash.TrashManagerAssembly-CSharp.dll_Excuted");
			TrashManager.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100678073);
			TrashManager.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100678074);
			TrashManager.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100678075);
			TrashManager.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100678076);
			TrashManager.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100678077);
			TrashManager.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100678078);
			TrashManager.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100678079);
			TrashManager.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100678080);
			TrashManager.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100678081);
			TrashManager.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100678082);
			TrashManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100678083);
			TrashManager.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100678084);
			TrashManager.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100678085);
			TrashManager.NativeMethodInfoPtr_ReplicateTransformData_Public_Void_TrashItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100678086);
			TrashManager.NativeMethodInfoPtr_SendTransformData_Private_Void_String_Vector3_Quaternion_Vector3_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100678087);
			TrashManager.NativeMethodInfoPtr_ReceiveTransformData_Private_Void_String_Vector3_Quaternion_Vector3_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100678088);
			TrashManager.NativeMethodInfoPtr_CreateTrashItem_Public_TrashItem_String_Vector3_Quaternion_Vector3_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100678089);
			TrashManager.NativeMethodInfoPtr_SendTrashItem_Private_Void_String_Vector3_Quaternion_Vector3_NetworkConnection_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100678090);
			TrashManager.NativeMethodInfoPtr_CreateTrashItem_Private_Void_NetworkConnection_String_Vector3_Quaternion_Vector3_NetworkConnection_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100678091);
			TrashManager.NativeMethodInfoPtr_CreateAndReturnTrashItem_Private_TrashItem_String_Vector3_Quaternion_Vector3_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100678092);
			TrashManager.NativeMethodInfoPtr_CreateTrashBag_Public_TrashItem_String_Vector3_Quaternion_TrashContentData_Vector3_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100678093);
			TrashManager.NativeMethodInfoPtr_SendTrashBag_Private_Void_String_Vector3_Quaternion_TrashContentData_Vector3_NetworkConnection_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100678094);
			TrashManager.NativeMethodInfoPtr_CreateTrashBag_Private_Void_NetworkConnection_String_Vector3_Quaternion_TrashContentData_Vector3_NetworkConnection_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100678095);
			TrashManager.NativeMethodInfoPtr_CreateAndReturnTrashBag_Private_TrashItem_String_Vector3_Quaternion_TrashContentData_Vector3_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100678096);
			TrashManager.NativeMethodInfoPtr_DestroyAllTrash_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100678097);
			TrashManager.NativeMethodInfoPtr_DestroyTrash_Public_Void_TrashItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100678098);
			TrashManager.NativeMethodInfoPtr_SendDestroyTrash_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100678099);
			TrashManager.NativeMethodInfoPtr_DestroyTrash_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100678100);
			TrashManager.NativeMethodInfoPtr_GetTrashPrefab_Public_TrashItem_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100678101);
			TrashManager.NativeMethodInfoPtr_GetRandomGeneratableTrashPrefab_Public_TrashItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100678102);
			TrashManager.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100678103);
			TrashManager.NativeMethodInfoPtr_WriteData_Public_Virtual_New_List_1_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100678104);
			TrashManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100678105);
			TrashManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100678106);
			TrashManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100678107);
			TrashManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100678108);
			TrashManager.NativeMethodInfoPtr_RpcWriter___Server_SendTransformData_2990100769_Private_Void_String_Vector3_Quaternion_Vector3_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100678109);
			TrashManager.NativeMethodInfoPtr_RpcLogic___SendTransformData_2990100769_Private_Void_String_Vector3_Quaternion_Vector3_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100678110);
			TrashManager.NativeMethodInfoPtr_RpcReader___Server_SendTransformData_2990100769_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100678111);
			TrashManager.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveTransformData_2990100769_Private_Void_String_Vector3_Quaternion_Vector3_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100678112);
			TrashManager.NativeMethodInfoPtr_RpcLogic___ReceiveTransformData_2990100769_Private_Void_String_Vector3_Quaternion_Vector3_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100678113);
			TrashManager.NativeMethodInfoPtr_RpcReader___Observers_ReceiveTransformData_2990100769_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100678114);
			TrashManager.NativeMethodInfoPtr_RpcWriter___Server_SendTrashItem_478112418_Private_Void_String_Vector3_Quaternion_Vector3_NetworkConnection_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100678115);
			TrashManager.NativeMethodInfoPtr_RpcLogic___SendTrashItem_478112418_Private_Void_String_Vector3_Quaternion_Vector3_NetworkConnection_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100678116);
			TrashManager.NativeMethodInfoPtr_RpcReader___Server_SendTrashItem_478112418_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100678117);
			TrashManager.NativeMethodInfoPtr_RpcWriter___Observers_CreateTrashItem_2385526393_Private_Void_NetworkConnection_String_Vector3_Quaternion_Vector3_NetworkConnection_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100678118);
			TrashManager.NativeMethodInfoPtr_RpcLogic___CreateTrashItem_2385526393_Private_Void_NetworkConnection_String_Vector3_Quaternion_Vector3_NetworkConnection_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100678119);
			TrashManager.NativeMethodInfoPtr_RpcReader___Observers_CreateTrashItem_2385526393_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100678120);
			TrashManager.NativeMethodInfoPtr_RpcWriter___Target_CreateTrashItem_2385526393_Private_Void_NetworkConnection_String_Vector3_Quaternion_Vector3_NetworkConnection_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100678121);
			TrashManager.NativeMethodInfoPtr_RpcReader___Target_CreateTrashItem_2385526393_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100678122);
			TrashManager.NativeMethodInfoPtr_RpcWriter___Server_SendTrashBag_3965031115_Private_Void_String_Vector3_Quaternion_TrashContentData_Vector3_NetworkConnection_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100678123);
			TrashManager.NativeMethodInfoPtr_RpcLogic___SendTrashBag_3965031115_Private_Void_String_Vector3_Quaternion_TrashContentData_Vector3_NetworkConnection_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100678124);
			TrashManager.NativeMethodInfoPtr_RpcReader___Server_SendTrashBag_3965031115_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100678125);
			TrashManager.NativeMethodInfoPtr_RpcWriter___Observers_CreateTrashBag_680856992_Private_Void_NetworkConnection_String_Vector3_Quaternion_TrashContentData_Vector3_NetworkConnection_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100678126);
			TrashManager.NativeMethodInfoPtr_RpcLogic___CreateTrashBag_680856992_Private_Void_NetworkConnection_String_Vector3_Quaternion_TrashContentData_Vector3_NetworkConnection_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100678127);
			TrashManager.NativeMethodInfoPtr_RpcReader___Observers_CreateTrashBag_680856992_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100678128);
			TrashManager.NativeMethodInfoPtr_RpcWriter___Target_CreateTrashBag_680856992_Private_Void_NetworkConnection_String_Vector3_Quaternion_TrashContentData_Vector3_NetworkConnection_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100678129);
			TrashManager.NativeMethodInfoPtr_RpcReader___Target_CreateTrashBag_680856992_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100678130);
			TrashManager.NativeMethodInfoPtr_RpcWriter___Server_SendDestroyTrash_3615296227_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100678131);
			TrashManager.NativeMethodInfoPtr_RpcLogic___SendDestroyTrash_3615296227_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100678132);
			TrashManager.NativeMethodInfoPtr_RpcReader___Server_SendDestroyTrash_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100678133);
			TrashManager.NativeMethodInfoPtr_RpcWriter___Observers_DestroyTrash_3615296227_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100678134);
			TrashManager.NativeMethodInfoPtr_RpcLogic___DestroyTrash_3615296227_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100678135);
			TrashManager.NativeMethodInfoPtr_RpcReader___Observers_DestroyTrash_3615296227_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100678136);
			TrashManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, 100678137);
		}

		// Token: 0x170023A3 RID: 9123
		// (get) Token: 0x06007569 RID: 30057 RVA: 0x001FF5CC File Offset: 0x001FD7CC
		public unsafe virtual string SaveFolderName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228938, XrefRangeEnd = 228940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170023A4 RID: 9124
		// (get) Token: 0x0600756A RID: 30058 RVA: 0x001FF604 File Offset: 0x001FD804
		public unsafe virtual string SaveFileName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228940, XrefRangeEnd = 228942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170023A5 RID: 9125
		// (get) Token: 0x0600756B RID: 30059 RVA: 0x001FF63C File Offset: 0x001FD83C
		public unsafe virtual Loader Loader
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 93781, RefRangeEnd = 93782, XrefRangeStart = 93781, XrefRangeEnd = 93782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Loader>(intPtr3) : null;
			}
		}

		// Token: 0x170023A6 RID: 9126
		// (get) Token: 0x0600756C RID: 30060 RVA: 0x001FF67C File Offset: 0x001FD87C
		public unsafe virtual bool ShouldSaveUnderFolder
		{
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 30137, RefRangeEnd = 30157, XrefRangeStart = 30137, XrefRangeEnd = 30157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170023A7 RID: 9127
		// (get) Token: 0x0600756D RID: 30061 RVA: 0x001FF6B8 File Offset: 0x001FD8B8
		// (set) Token: 0x0600756E RID: 30062 RVA: 0x001FF6F8 File Offset: 0x001FD8F8
		public unsafe virtual List<string> LocalExtraFiles
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170023A8 RID: 9128
		// (get) Token: 0x0600756F RID: 30063 RVA: 0x001FF73C File Offset: 0x001FD93C
		// (set) Token: 0x06007570 RID: 30064 RVA: 0x001FF77C File Offset: 0x001FD97C
		public unsafe virtual List<string> LocalExtraFolders
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170023A9 RID: 9129
		// (get) Token: 0x06007571 RID: 30065 RVA: 0x001FF7C0 File Offset: 0x001FD9C0
		// (set) Token: 0x06007572 RID: 30066 RVA: 0x001FF7FC File Offset: 0x001FD9FC
		public unsafe virtual bool HasChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06007573 RID: 30067 RVA: 0x001FF83C File Offset: 0x001FDA3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228942, XrefRangeEnd = 228945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007574 RID: 30068 RVA: 0x001FF878 File Offset: 0x001FDA78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228945, XrefRangeEnd = 228951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeSaveable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashManager.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007575 RID: 30069 RVA: 0x001FF8B4 File Offset: 0x001FDAB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228951, XrefRangeEnd = 228987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashManager.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007576 RID: 30070 RVA: 0x001FF904 File Offset: 0x001FDB04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228987, XrefRangeEnd = 228999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReplicateTransformData(TrashItem trash)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(trash);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_ReplicateTransformData_Public_Void_TrashItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007577 RID: 30071 RVA: 0x001FF948 File Offset: 0x001FDB48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228999, XrefRangeEnd = 229000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendTransformData(string guid, Vector3 position, Quaternion rotation, Vector3 velocity, NetworkConnection sender)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref velocity;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sender);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_SendTransformData_Private_Void_String_Vector3_Quaternion_Vector3_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007578 RID: 30072 RVA: 0x001FF9C8 File Offset: 0x001FDBC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229000, XrefRangeEnd = 229001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveTransformData(string guid, Vector3 position, Quaternion rotation, Vector3 velocity, NetworkConnection sender)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref velocity;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sender);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_ReceiveTransformData_Private_Void_String_Vector3_Quaternion_Vector3_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007579 RID: 30073 RVA: 0x001FFA48 File Offset: 0x001FDC48
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 229013, RefRangeEnd = 229027, XrefRangeStart = 229001, XrefRangeEnd = 229013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashItem CreateTrashItem(string id, Vector3 posiiton, Quaternion rotation, Vector3 initialVelocity = default(Vector3), string guid = "", bool startKinematic = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref posiiton;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initialVelocity;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startKinematic;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_CreateTrashItem_Public_TrashItem_String_Vector3_Quaternion_Vector3_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TrashItem>(intPtr3) : null;
		}

		// Token: 0x0600757A RID: 30074 RVA: 0x001FFAE4 File Offset: 0x001FDCE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229027, XrefRangeEnd = 229028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendTrashItem(string id, Vector3 position, Quaternion rotation, Vector3 initialVelocity, NetworkConnection sender, string guid, bool startKinematic = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initialVelocity;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sender);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startKinematic;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_SendTrashItem_Private_Void_String_Vector3_Quaternion_Vector3_NetworkConnection_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600757B RID: 30075 RVA: 0x001FFB84 File Offset: 0x001FDD84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229028, XrefRangeEnd = 229029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateTrashItem(NetworkConnection conn, string id, Vector3 position, Quaternion rotation, Vector3 initialVelocity, NetworkConnection sender, string guid, bool startKinematic = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initialVelocity;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sender);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startKinematic;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_CreateTrashItem_Private_Void_NetworkConnection_String_Vector3_Quaternion_Vector3_NetworkConnection_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600757C RID: 30076 RVA: 0x001FFC38 File Offset: 0x001FDE38
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 229067, RefRangeEnd = 229071, XrefRangeStart = 229029, XrefRangeEnd = 229067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashItem CreateAndReturnTrashItem(string id, Vector3 position, Quaternion rotation, Vector3 initialVelocity, string guid, bool startKinematic)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initialVelocity;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startKinematic;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_CreateAndReturnTrashItem_Private_TrashItem_String_Vector3_Quaternion_Vector3_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TrashItem>(intPtr3) : null;
		}

		// Token: 0x0600757D RID: 30077 RVA: 0x001FFCD4 File Offset: 0x001FDED4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 229083, RefRangeEnd = 229088, XrefRangeStart = 229071, XrefRangeEnd = 229083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashItem CreateTrashBag(string id, Vector3 posiiton, Quaternion rotation, TrashContentData content, Vector3 initialVelocity = default(Vector3), string guid = "", bool startKinematic = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref posiiton;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initialVelocity;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startKinematic;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_CreateTrashBag_Public_TrashItem_String_Vector3_Quaternion_TrashContentData_Vector3_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TrashItem>(intPtr3) : null;
		}

		// Token: 0x0600757E RID: 30078 RVA: 0x001FFD84 File Offset: 0x001FDF84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229088, XrefRangeEnd = 229089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendTrashBag(string id, Vector3 position, Quaternion rotation, TrashContentData content, Vector3 initialVelocity, NetworkConnection sender, string guid, bool startKinematic = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initialVelocity;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sender);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startKinematic;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_SendTrashBag_Private_Void_String_Vector3_Quaternion_TrashContentData_Vector3_NetworkConnection_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600757F RID: 30079 RVA: 0x001FFE38 File Offset: 0x001FE038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229089, XrefRangeEnd = 229090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateTrashBag(NetworkConnection conn, string id, Vector3 position, Quaternion rotation, TrashContentData content, Vector3 initialVelocity, NetworkConnection sender, string guid, bool startKinematic = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initialVelocity;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sender);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startKinematic;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_CreateTrashBag_Private_Void_NetworkConnection_String_Vector3_Quaternion_TrashContentData_Vector3_NetworkConnection_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007580 RID: 30080 RVA: 0x001FFF00 File Offset: 0x001FE100
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 229126, RefRangeEnd = 229130, XrefRangeStart = 229090, XrefRangeEnd = 229126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashItem CreateAndReturnTrashBag(string id, Vector3 position, Quaternion rotation, TrashContentData content, Vector3 initialVelocity, string guid, bool startKinematic)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initialVelocity;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startKinematic;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_CreateAndReturnTrashBag_Private_TrashItem_String_Vector3_Quaternion_TrashContentData_Vector3_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TrashItem>(intPtr3) : null;
		}

		// Token: 0x06007581 RID: 30081 RVA: 0x001FFFB0 File Offset: 0x001FE1B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 229146, RefRangeEnd = 229147, XrefRangeStart = 229130, XrefRangeEnd = 229146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyAllTrash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_DestroyAllTrash_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007582 RID: 30082 RVA: 0x001FFFE4 File Offset: 0x001FE1E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 229169, RefRangeEnd = 229171, XrefRangeStart = 229147, XrefRangeEnd = 229169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyTrash(TrashItem trash)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(trash);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_DestroyTrash_Public_Void_TrashItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007583 RID: 30083 RVA: 0x00200028 File Offset: 0x001FE228
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229171, XrefRangeEnd = 229193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendDestroyTrash(string guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_SendDestroyTrash_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007584 RID: 30084 RVA: 0x0020006C File Offset: 0x001FE26C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 229215, RefRangeEnd = 229218, XrefRangeStart = 229193, XrefRangeEnd = 229215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyTrash(string guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_DestroyTrash_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007585 RID: 30085 RVA: 0x002000B0 File Offset: 0x001FE2B0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 229233, RefRangeEnd = 229238, XrefRangeStart = 229218, XrefRangeEnd = 229233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashItem GetTrashPrefab(string id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_GetTrashPrefab_Public_TrashItem_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TrashItem>(intPtr3) : null;
		}

		// Token: 0x06007586 RID: 30086 RVA: 0x00200100 File Offset: 0x001FE300
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 229258, RefRangeEnd = 229259, XrefRangeStart = 229238, XrefRangeEnd = 229258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashItem GetRandomGeneratableTrashPrefab()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_GetRandomGeneratableTrashPrefab_Public_TrashItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TrashItem>(intPtr3) : null;
		}

		// Token: 0x06007587 RID: 30087 RVA: 0x00200140 File Offset: 0x001FE340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229259, XrefRangeEnd = 229281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashManager.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06007588 RID: 30088 RVA: 0x00200184 File Offset: 0x001FE384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229281, XrefRangeEnd = 229316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual List<string> WriteData(string parentFolderPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(parentFolderPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashManager.NativeMethodInfoPtr_WriteData_Public_Virtual_New_List_1_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
		}

		// Token: 0x06007589 RID: 30089 RVA: 0x002001E0 File Offset: 0x001FE3E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229316, XrefRangeEnd = 229357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600758A RID: 30090 RVA: 0x0020021C File Offset: 0x001FE41C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229357, XrefRangeEnd = 229422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600758B RID: 30091 RVA: 0x00200258 File Offset: 0x001FE458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229422, XrefRangeEnd = 229425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600758C RID: 30092 RVA: 0x00200294 File Offset: 0x001FE494
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600758D RID: 30093 RVA: 0x002002D0 File Offset: 0x001FE4D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 229454, RefRangeEnd = 229456, XrefRangeStart = 229425, XrefRangeEnd = 229454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendTransformData_2990100769(string guid, Vector3 position, Quaternion rotation, Vector3 velocity, NetworkConnection sender)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref velocity;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sender);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_RpcWriter___Server_SendTransformData_2990100769_Private_Void_String_Vector3_Quaternion_Vector3_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600758E RID: 30094 RVA: 0x00200350 File Offset: 0x001FE550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendTransformData_2990100769(string guid, Vector3 position, Quaternion rotation, Vector3 velocity, NetworkConnection sender)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref velocity;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sender);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_RpcLogic___SendTransformData_2990100769_Private_Void_String_Vector3_Quaternion_Vector3_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600758F RID: 30095 RVA: 0x002003D0 File Offset: 0x001FE5D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229456, XrefRangeEnd = 229468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendTransformData_2990100769(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_RpcReader___Server_SendTransformData_2990100769_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007590 RID: 30096 RVA: 0x00200434 File Offset: 0x001FE634
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 229497, RefRangeEnd = 229500, XrefRangeStart = 229468, XrefRangeEnd = 229497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveTransformData_2990100769(string guid, Vector3 position, Quaternion rotation, Vector3 velocity, NetworkConnection sender)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref velocity;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sender);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveTransformData_2990100769_Private_Void_String_Vector3_Quaternion_Vector3_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007591 RID: 30097 RVA: 0x002004B4 File Offset: 0x001FE6B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229500, XrefRangeEnd = 229517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceiveTransformData_2990100769(string guid, Vector3 position, Quaternion rotation, Vector3 velocity, NetworkConnection sender)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref velocity;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sender);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_RpcLogic___ReceiveTransformData_2990100769_Private_Void_String_Vector3_Quaternion_Vector3_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007592 RID: 30098 RVA: 0x00200534 File Offset: 0x001FE734
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229517, XrefRangeEnd = 229545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveTransformData_2990100769(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_RpcReader___Observers_ReceiveTransformData_2990100769_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007593 RID: 30099 RVA: 0x00200584 File Offset: 0x001FE784
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 229576, RefRangeEnd = 229578, XrefRangeStart = 229545, XrefRangeEnd = 229576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendTrashItem_478112418(string id, Vector3 position, Quaternion rotation, Vector3 initialVelocity, NetworkConnection sender, string guid, bool startKinematic = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initialVelocity;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sender);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startKinematic;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_RpcWriter___Server_SendTrashItem_478112418_Private_Void_String_Vector3_Quaternion_Vector3_NetworkConnection_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007594 RID: 30100 RVA: 0x00200624 File Offset: 0x001FE824
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229578, XrefRangeEnd = 229585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendTrashItem_478112418(string id, Vector3 position, Quaternion rotation, Vector3 initialVelocity, NetworkConnection sender, string guid, bool startKinematic = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initialVelocity;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sender);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startKinematic;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_RpcLogic___SendTrashItem_478112418_Private_Void_String_Vector3_Quaternion_Vector3_NetworkConnection_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007595 RID: 30101 RVA: 0x002006C4 File Offset: 0x001FE8C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229585, XrefRangeEnd = 229604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendTrashItem_478112418(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_RpcReader___Server_SendTrashItem_478112418_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007596 RID: 30102 RVA: 0x00200728 File Offset: 0x001FE928
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 229635, RefRangeEnd = 229638, XrefRangeStart = 229604, XrefRangeEnd = 229635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_CreateTrashItem_2385526393(NetworkConnection conn, string id, Vector3 position, Quaternion rotation, Vector3 initialVelocity, NetworkConnection sender, string guid, bool startKinematic = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initialVelocity;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sender);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startKinematic;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_RpcWriter___Observers_CreateTrashItem_2385526393_Private_Void_NetworkConnection_String_Vector3_Quaternion_Vector3_NetworkConnection_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007597 RID: 30103 RVA: 0x002007DC File Offset: 0x001FE9DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229638, XrefRangeEnd = 229640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___CreateTrashItem_2385526393(NetworkConnection conn, string id, Vector3 position, Quaternion rotation, Vector3 initialVelocity, NetworkConnection sender, string guid, bool startKinematic = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initialVelocity;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sender);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startKinematic;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_RpcLogic___CreateTrashItem_2385526393_Private_Void_NetworkConnection_String_Vector3_Quaternion_Vector3_NetworkConnection_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007598 RID: 30104 RVA: 0x00200890 File Offset: 0x001FEA90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229640, XrefRangeEnd = 229654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_CreateTrashItem_2385526393(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_RpcReader___Observers_CreateTrashItem_2385526393_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007599 RID: 30105 RVA: 0x002008E0 File Offset: 0x001FEAE0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 229685, RefRangeEnd = 229687, XrefRangeStart = 229654, XrefRangeEnd = 229685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_CreateTrashItem_2385526393(NetworkConnection conn, string id, Vector3 position, Quaternion rotation, Vector3 initialVelocity, NetworkConnection sender, string guid, bool startKinematic = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initialVelocity;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sender);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startKinematic;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_RpcWriter___Target_CreateTrashItem_2385526393_Private_Void_NetworkConnection_String_Vector3_Quaternion_Vector3_NetworkConnection_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600759A RID: 30106 RVA: 0x00200994 File Offset: 0x001FEB94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229687, XrefRangeEnd = 229702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_CreateTrashItem_2385526393(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_RpcReader___Target_CreateTrashItem_2385526393_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600759B RID: 30107 RVA: 0x002009E4 File Offset: 0x001FEBE4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 229734, RefRangeEnd = 229736, XrefRangeStart = 229702, XrefRangeEnd = 229734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendTrashBag_3965031115(string id, Vector3 position, Quaternion rotation, TrashContentData content, Vector3 initialVelocity, NetworkConnection sender, string guid, bool startKinematic = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initialVelocity;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sender);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startKinematic;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_RpcWriter___Server_SendTrashBag_3965031115_Private_Void_String_Vector3_Quaternion_TrashContentData_Vector3_NetworkConnection_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600759C RID: 30108 RVA: 0x00200A98 File Offset: 0x001FEC98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229736, XrefRangeEnd = 229743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendTrashBag_3965031115(string id, Vector3 position, Quaternion rotation, TrashContentData content, Vector3 initialVelocity, NetworkConnection sender, string guid, bool startKinematic = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initialVelocity;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sender);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startKinematic;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_RpcLogic___SendTrashBag_3965031115_Private_Void_String_Vector3_Quaternion_TrashContentData_Vector3_NetworkConnection_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600759D RID: 30109 RVA: 0x00200B4C File Offset: 0x001FED4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229743, XrefRangeEnd = 229763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendTrashBag_3965031115(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_RpcReader___Server_SendTrashBag_3965031115_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600759E RID: 30110 RVA: 0x00200BB0 File Offset: 0x001FEDB0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 229795, RefRangeEnd = 229797, XrefRangeStart = 229763, XrefRangeEnd = 229795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_CreateTrashBag_680856992(NetworkConnection conn, string id, Vector3 position, Quaternion rotation, TrashContentData content, Vector3 initialVelocity, NetworkConnection sender, string guid, bool startKinematic = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initialVelocity;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sender);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startKinematic;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_RpcWriter___Observers_CreateTrashBag_680856992_Private_Void_NetworkConnection_String_Vector3_Quaternion_TrashContentData_Vector3_NetworkConnection_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600759F RID: 30111 RVA: 0x00200C78 File Offset: 0x001FEE78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229797, XrefRangeEnd = 229799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___CreateTrashBag_680856992(NetworkConnection conn, string id, Vector3 position, Quaternion rotation, TrashContentData content, Vector3 initialVelocity, NetworkConnection sender, string guid, bool startKinematic = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initialVelocity;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sender);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startKinematic;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_RpcLogic___CreateTrashBag_680856992_Private_Void_NetworkConnection_String_Vector3_Quaternion_TrashContentData_Vector3_NetworkConnection_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060075A0 RID: 30112 RVA: 0x00200D40 File Offset: 0x001FEF40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229799, XrefRangeEnd = 229814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_CreateTrashBag_680856992(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_RpcReader___Observers_CreateTrashBag_680856992_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060075A1 RID: 30113 RVA: 0x00200D90 File Offset: 0x001FEF90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 229846, RefRangeEnd = 229847, XrefRangeStart = 229814, XrefRangeEnd = 229846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_CreateTrashBag_680856992(NetworkConnection conn, string id, Vector3 position, Quaternion rotation, TrashContentData content, Vector3 initialVelocity, NetworkConnection sender, string guid, bool startKinematic = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initialVelocity;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sender);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startKinematic;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_RpcWriter___Target_CreateTrashBag_680856992_Private_Void_NetworkConnection_String_Vector3_Quaternion_TrashContentData_Vector3_NetworkConnection_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060075A2 RID: 30114 RVA: 0x00200E58 File Offset: 0x001FF058
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229847, XrefRangeEnd = 229863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_CreateTrashBag_680856992(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_RpcReader___Target_CreateTrashBag_680856992_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060075A3 RID: 30115 RVA: 0x00200EA8 File Offset: 0x001FF0A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229863, XrefRangeEnd = 229882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendDestroyTrash_3615296227(string guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_RpcWriter___Server_SendDestroyTrash_3615296227_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060075A4 RID: 30116 RVA: 0x00200EEC File Offset: 0x001FF0EC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 229215, RefRangeEnd = 229218, XrefRangeStart = 229215, XrefRangeEnd = 229218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendDestroyTrash_3615296227(string guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_RpcLogic___SendDestroyTrash_3615296227_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060075A5 RID: 30117 RVA: 0x00200F30 File Offset: 0x001FF130
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229882, XrefRangeEnd = 229886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendDestroyTrash_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_RpcReader___Server_SendDestroyTrash_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060075A6 RID: 30118 RVA: 0x00200F94 File Offset: 0x001FF194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229886, XrefRangeEnd = 229905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_DestroyTrash_3615296227(string guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_RpcWriter___Observers_DestroyTrash_3615296227_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060075A7 RID: 30119 RVA: 0x00200FD8 File Offset: 0x001FF1D8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 229926, RefRangeEnd = 229929, XrefRangeStart = 229905, XrefRangeEnd = 229926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___DestroyTrash_3615296227(string guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_RpcLogic___DestroyTrash_3615296227_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060075A8 RID: 30120 RVA: 0x0020101C File Offset: 0x001FF21C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229929, XrefRangeEnd = 229933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_DestroyTrash_3615296227(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.NativeMethodInfoPtr_RpcReader___Observers_DestroyTrash_3615296227_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060075A9 RID: 30121 RVA: 0x0020106C File Offset: 0x001FF26C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229933, XrefRangeEnd = 229936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060075AA RID: 30122 RVA: 0x00037AA5 File Offset: 0x00035CA5
		public TrashManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002396 RID: 9110
		// (get) Token: 0x060075AB RID: 30123 RVA: 0x002010A8 File Offset: 0x001FF2A8
		// (set) Token: 0x060075AC RID: 30124 RVA: 0x00037AAE File Offset: 0x00035CAE
		public unsafe static int TRASH_ITEM_LIMIT
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(TrashManager.NativeFieldInfoPtr_TRASH_ITEM_LIMIT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TrashManager.NativeFieldInfoPtr_TRASH_ITEM_LIMIT, (void*)(&value));
			}
		}

		// Token: 0x17002397 RID: 9111
		// (get) Token: 0x060075AD RID: 30125 RVA: 0x002010C4 File Offset: 0x001FF2C4
		// (set) Token: 0x060075AE RID: 30126 RVA: 0x00037ABC File Offset: 0x00035CBC
		public unsafe Il2CppReferenceArray<TrashItem> TrashPrefabs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashManager.NativeFieldInfoPtr_TrashPrefabs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TrashItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashManager.NativeFieldInfoPtr_TrashPrefabs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002398 RID: 9112
		// (get) Token: 0x060075AF RID: 30127 RVA: 0x002010F4 File Offset: 0x001FF2F4
		// (set) Token: 0x060075B0 RID: 30128 RVA: 0x00037ADB File Offset: 0x00035CDB
		public unsafe TrashItem TrashBagPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashManager.NativeFieldInfoPtr_TrashBagPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashManager.NativeFieldInfoPtr_TrashBagPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002399 RID: 9113
		// (get) Token: 0x060075B1 RID: 30129 RVA: 0x00201124 File Offset: 0x001FF324
		// (set) Token: 0x060075B2 RID: 30130 RVA: 0x00037AFA File Offset: 0x00035CFA
		public unsafe Il2CppReferenceArray<TrashManager.TrashItemData> GenerateableTrashItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashManager.NativeFieldInfoPtr_GenerateableTrashItems);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TrashManager.TrashItemData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashManager.NativeFieldInfoPtr_GenerateableTrashItems), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700239A RID: 9114
		// (get) Token: 0x060075B3 RID: 30131 RVA: 0x00201154 File Offset: 0x001FF354
		// (set) Token: 0x060075B4 RID: 30132 RVA: 0x00037B19 File Offset: 0x00035D19
		public unsafe List<TrashItem> trashItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashManager.NativeFieldInfoPtr_trashItems);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TrashItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashManager.NativeFieldInfoPtr_trashItems), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700239B RID: 9115
		// (get) Token: 0x060075B5 RID: 30133 RVA: 0x00201184 File Offset: 0x001FF384
		// (set) Token: 0x060075B6 RID: 30134 RVA: 0x00037B38 File Offset: 0x00035D38
		public unsafe float TrashForceMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashManager.NativeFieldInfoPtr_TrashForceMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashManager.NativeFieldInfoPtr_TrashForceMultiplier)) = value;
			}
		}

		// Token: 0x1700239C RID: 9116
		// (get) Token: 0x060075B7 RID: 30135 RVA: 0x002011AC File Offset: 0x001FF3AC
		// (set) Token: 0x060075B8 RID: 30136 RVA: 0x00037B53 File Offset: 0x00035D53
		public unsafe TrashLoader loader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashManager.NativeFieldInfoPtr_loader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashLoader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashManager.NativeFieldInfoPtr_loader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700239D RID: 9117
		// (get) Token: 0x060075B9 RID: 30137 RVA: 0x002011DC File Offset: 0x001FF3DC
		// (set) Token: 0x060075BA RID: 30138 RVA: 0x00037B72 File Offset: 0x00035D72
		public unsafe List<string> _LocalExtraFiles_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700239E RID: 9118
		// (get) Token: 0x060075BB RID: 30139 RVA: 0x0020120C File Offset: 0x001FF40C
		// (set) Token: 0x060075BC RID: 30140 RVA: 0x00037B91 File Offset: 0x00035D91
		public unsafe List<string> _LocalExtraFolders_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700239F RID: 9119
		// (get) Token: 0x060075BD RID: 30141 RVA: 0x0020123C File Offset: 0x001FF43C
		// (set) Token: 0x060075BE RID: 30142 RVA: 0x00037BB0 File Offset: 0x00035DB0
		public unsafe bool _HasChanged_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashManager.NativeFieldInfoPtr__HasChanged_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashManager.NativeFieldInfoPtr__HasChanged_k__BackingField)) = value;
			}
		}

		// Token: 0x170023A0 RID: 9120
		// (get) Token: 0x060075BF RID: 30143 RVA: 0x00201264 File Offset: 0x001FF464
		// (set) Token: 0x060075C0 RID: 30144 RVA: 0x00037BCB File Offset: 0x00035DCB
		public unsafe List<string> writtenItemFiles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashManager.NativeFieldInfoPtr_writtenItemFiles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashManager.NativeFieldInfoPtr_writtenItemFiles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023A1 RID: 9121
		// (get) Token: 0x060075C1 RID: 30145 RVA: 0x00201294 File Offset: 0x001FF494
		// (set) Token: 0x060075C2 RID: 30146 RVA: 0x00037BEA File Offset: 0x00035DEA
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashManager.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashManager.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170023A2 RID: 9122
		// (get) Token: 0x060075C3 RID: 30147 RVA: 0x002012BC File Offset: 0x001FF4BC
		// (set) Token: 0x060075C4 RID: 30148 RVA: 0x00037C05 File Offset: 0x00035E05
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashManager.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashManager.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04005034 RID: 20532
		private static readonly IntPtr NativeFieldInfoPtr_TRASH_ITEM_LIMIT;

		// Token: 0x04005035 RID: 20533
		private static readonly IntPtr NativeFieldInfoPtr_TrashPrefabs;

		// Token: 0x04005036 RID: 20534
		private static readonly IntPtr NativeFieldInfoPtr_TrashBagPrefab;

		// Token: 0x04005037 RID: 20535
		private static readonly IntPtr NativeFieldInfoPtr_GenerateableTrashItems;

		// Token: 0x04005038 RID: 20536
		private static readonly IntPtr NativeFieldInfoPtr_trashItems;

		// Token: 0x04005039 RID: 20537
		private static readonly IntPtr NativeFieldInfoPtr_TrashForceMultiplier;

		// Token: 0x0400503A RID: 20538
		private static readonly IntPtr NativeFieldInfoPtr_loader;

		// Token: 0x0400503B RID: 20539
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFiles_k__BackingField;

		// Token: 0x0400503C RID: 20540
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFolders_k__BackingField;

		// Token: 0x0400503D RID: 20541
		private static readonly IntPtr NativeFieldInfoPtr__HasChanged_k__BackingField;

		// Token: 0x0400503E RID: 20542
		private static readonly IntPtr NativeFieldInfoPtr_writtenItemFiles;

		// Token: 0x0400503F RID: 20543
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04005040 RID: 20544
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04005041 RID: 20545
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04005042 RID: 20546
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04005043 RID: 20547
		private static readonly IntPtr NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0;

		// Token: 0x04005044 RID: 20548
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04005045 RID: 20549
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04005046 RID: 20550
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04005047 RID: 20551
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04005048 RID: 20552
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04005049 RID: 20553
		private static readonly IntPtr NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400504A RID: 20554
		private static readonly IntPtr NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x0400504B RID: 20555
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x0400504C RID: 20556
		private static readonly IntPtr NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0;

		// Token: 0x0400504D RID: 20557
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x0400504E RID: 20558
		private static readonly IntPtr NativeMethodInfoPtr_ReplicateTransformData_Public_Void_TrashItem_0;

		// Token: 0x0400504F RID: 20559
		private static readonly IntPtr NativeMethodInfoPtr_SendTransformData_Private_Void_String_Vector3_Quaternion_Vector3_NetworkConnection_0;

		// Token: 0x04005050 RID: 20560
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveTransformData_Private_Void_String_Vector3_Quaternion_Vector3_NetworkConnection_0;

		// Token: 0x04005051 RID: 20561
		private static readonly IntPtr NativeMethodInfoPtr_CreateTrashItem_Public_TrashItem_String_Vector3_Quaternion_Vector3_String_Boolean_0;

		// Token: 0x04005052 RID: 20562
		private static readonly IntPtr NativeMethodInfoPtr_SendTrashItem_Private_Void_String_Vector3_Quaternion_Vector3_NetworkConnection_String_Boolean_0;

		// Token: 0x04005053 RID: 20563
		private static readonly IntPtr NativeMethodInfoPtr_CreateTrashItem_Private_Void_NetworkConnection_String_Vector3_Quaternion_Vector3_NetworkConnection_String_Boolean_0;

		// Token: 0x04005054 RID: 20564
		private static readonly IntPtr NativeMethodInfoPtr_CreateAndReturnTrashItem_Private_TrashItem_String_Vector3_Quaternion_Vector3_String_Boolean_0;

		// Token: 0x04005055 RID: 20565
		private static readonly IntPtr NativeMethodInfoPtr_CreateTrashBag_Public_TrashItem_String_Vector3_Quaternion_TrashContentData_Vector3_String_Boolean_0;

		// Token: 0x04005056 RID: 20566
		private static readonly IntPtr NativeMethodInfoPtr_SendTrashBag_Private_Void_String_Vector3_Quaternion_TrashContentData_Vector3_NetworkConnection_String_Boolean_0;

		// Token: 0x04005057 RID: 20567
		private static readonly IntPtr NativeMethodInfoPtr_CreateTrashBag_Private_Void_NetworkConnection_String_Vector3_Quaternion_TrashContentData_Vector3_NetworkConnection_String_Boolean_0;

		// Token: 0x04005058 RID: 20568
		private static readonly IntPtr NativeMethodInfoPtr_CreateAndReturnTrashBag_Private_TrashItem_String_Vector3_Quaternion_TrashContentData_Vector3_String_Boolean_0;

		// Token: 0x04005059 RID: 20569
		private static readonly IntPtr NativeMethodInfoPtr_DestroyAllTrash_Public_Void_0;

		// Token: 0x0400505A RID: 20570
		private static readonly IntPtr NativeMethodInfoPtr_DestroyTrash_Public_Void_TrashItem_0;

		// Token: 0x0400505B RID: 20571
		private static readonly IntPtr NativeMethodInfoPtr_SendDestroyTrash_Private_Void_String_0;

		// Token: 0x0400505C RID: 20572
		private static readonly IntPtr NativeMethodInfoPtr_DestroyTrash_Private_Void_String_0;

		// Token: 0x0400505D RID: 20573
		private static readonly IntPtr NativeMethodInfoPtr_GetTrashPrefab_Public_TrashItem_String_0;

		// Token: 0x0400505E RID: 20574
		private static readonly IntPtr NativeMethodInfoPtr_GetRandomGeneratableTrashPrefab_Public_TrashItem_0;

		// Token: 0x0400505F RID: 20575
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0;

		// Token: 0x04005060 RID: 20576
		private static readonly IntPtr NativeMethodInfoPtr_WriteData_Public_Virtual_New_List_1_String_String_0;

		// Token: 0x04005061 RID: 20577
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005062 RID: 20578
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04005063 RID: 20579
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04005064 RID: 20580
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04005065 RID: 20581
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendTransformData_2990100769_Private_Void_String_Vector3_Quaternion_Vector3_NetworkConnection_0;

		// Token: 0x04005066 RID: 20582
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendTransformData_2990100769_Private_Void_String_Vector3_Quaternion_Vector3_NetworkConnection_0;

		// Token: 0x04005067 RID: 20583
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendTransformData_2990100769_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04005068 RID: 20584
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveTransformData_2990100769_Private_Void_String_Vector3_Quaternion_Vector3_NetworkConnection_0;

		// Token: 0x04005069 RID: 20585
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveTransformData_2990100769_Private_Void_String_Vector3_Quaternion_Vector3_NetworkConnection_0;

		// Token: 0x0400506A RID: 20586
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveTransformData_2990100769_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400506B RID: 20587
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendTrashItem_478112418_Private_Void_String_Vector3_Quaternion_Vector3_NetworkConnection_String_Boolean_0;

		// Token: 0x0400506C RID: 20588
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendTrashItem_478112418_Private_Void_String_Vector3_Quaternion_Vector3_NetworkConnection_String_Boolean_0;

		// Token: 0x0400506D RID: 20589
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendTrashItem_478112418_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400506E RID: 20590
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_CreateTrashItem_2385526393_Private_Void_NetworkConnection_String_Vector3_Quaternion_Vector3_NetworkConnection_String_Boolean_0;

		// Token: 0x0400506F RID: 20591
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___CreateTrashItem_2385526393_Private_Void_NetworkConnection_String_Vector3_Quaternion_Vector3_NetworkConnection_String_Boolean_0;

		// Token: 0x04005070 RID: 20592
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_CreateTrashItem_2385526393_Private_Void_PooledReader_Channel_0;

		// Token: 0x04005071 RID: 20593
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_CreateTrashItem_2385526393_Private_Void_NetworkConnection_String_Vector3_Quaternion_Vector3_NetworkConnection_String_Boolean_0;

		// Token: 0x04005072 RID: 20594
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_CreateTrashItem_2385526393_Private_Void_PooledReader_Channel_0;

		// Token: 0x04005073 RID: 20595
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendTrashBag_3965031115_Private_Void_String_Vector3_Quaternion_TrashContentData_Vector3_NetworkConnection_String_Boolean_0;

		// Token: 0x04005074 RID: 20596
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendTrashBag_3965031115_Private_Void_String_Vector3_Quaternion_TrashContentData_Vector3_NetworkConnection_String_Boolean_0;

		// Token: 0x04005075 RID: 20597
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendTrashBag_3965031115_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04005076 RID: 20598
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_CreateTrashBag_680856992_Private_Void_NetworkConnection_String_Vector3_Quaternion_TrashContentData_Vector3_NetworkConnection_String_Boolean_0;

		// Token: 0x04005077 RID: 20599
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___CreateTrashBag_680856992_Private_Void_NetworkConnection_String_Vector3_Quaternion_TrashContentData_Vector3_NetworkConnection_String_Boolean_0;

		// Token: 0x04005078 RID: 20600
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_CreateTrashBag_680856992_Private_Void_PooledReader_Channel_0;

		// Token: 0x04005079 RID: 20601
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_CreateTrashBag_680856992_Private_Void_NetworkConnection_String_Vector3_Quaternion_TrashContentData_Vector3_NetworkConnection_String_Boolean_0;

		// Token: 0x0400507A RID: 20602
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_CreateTrashBag_680856992_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400507B RID: 20603
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendDestroyTrash_3615296227_Private_Void_String_0;

		// Token: 0x0400507C RID: 20604
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendDestroyTrash_3615296227_Private_Void_String_0;

		// Token: 0x0400507D RID: 20605
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendDestroyTrash_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400507E RID: 20606
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_DestroyTrash_3615296227_Private_Void_String_0;

		// Token: 0x0400507F RID: 20607
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___DestroyTrash_3615296227_Private_Void_String_0;

		// Token: 0x04005080 RID: 20608
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_DestroyTrash_3615296227_Private_Void_PooledReader_Channel_0;

		// Token: 0x04005081 RID: 20609
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x02000A92 RID: 2706
		[Serializable]
		public class TrashItemData : Il2CppSystem.Object
		{
			// Token: 0x0600D28C RID: 53900 RVA: 0x00325BEC File Offset: 0x00323DEC
			// Note: this type is marked as 'beforefieldinit'.
			static TrashItemData()
			{
				Il2CppClassPointerStore<TrashManager.TrashItemData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, "TrashItemData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashManager.TrashItemData>.NativeClassPtr);
				TrashManager.TrashItemData.NativeFieldInfoPtr_Item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashManager.TrashItemData>.NativeClassPtr, "Item");
				TrashManager.TrashItemData.NativeFieldInfoPtr_GenerationChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashManager.TrashItemData>.NativeClassPtr, "GenerationChance");
				TrashManager.TrashItemData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager.TrashItemData>.NativeClassPtr, 100678138);
			}

			// Token: 0x0600D28D RID: 53901 RVA: 0x00325C54 File Offset: 0x00323E54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TrashItemData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashManager.TrashItemData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.TrashItemData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D28E RID: 53902 RVA: 0x000667CC File Offset: 0x000649CC
			public TrashItemData(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004152 RID: 16722
			// (get) Token: 0x0600D28F RID: 53903 RVA: 0x00325C90 File Offset: 0x00323E90
			// (set) Token: 0x0600D290 RID: 53904 RVA: 0x000667D5 File Offset: 0x000649D5
			public unsafe TrashItem Item
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashManager.TrashItemData.NativeFieldInfoPtr_Item);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashItem>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashManager.TrashItemData.NativeFieldInfoPtr_Item), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004153 RID: 16723
			// (get) Token: 0x0600D291 RID: 53905 RVA: 0x00325CC0 File Offset: 0x00323EC0
			// (set) Token: 0x0600D292 RID: 53906 RVA: 0x000667F4 File Offset: 0x000649F4
			public unsafe float GenerationChance
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashManager.TrashItemData.NativeFieldInfoPtr_GenerationChance);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashManager.TrashItemData.NativeFieldInfoPtr_GenerationChance)) = value;
				}
			}

			// Token: 0x04008DF6 RID: 36342
			private static readonly IntPtr NativeFieldInfoPtr_Item;

			// Token: 0x04008DF7 RID: 36343
			private static readonly IntPtr NativeFieldInfoPtr_GenerationChance;

			// Token: 0x04008DF8 RID: 36344
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000A93 RID: 2707
		[ObfuscatedName("ScheduleOne.Trash.TrashManager+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D293 RID: 53907 RVA: 0x00325CE8 File Offset: 0x00323EE8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<TrashManager.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashManager.__c>.NativeClassPtr);
				TrashManager.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashManager.__c>.NativeClassPtr, "<>9");
				TrashManager.__c.NativeFieldInfoPtr___9__48_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashManager.__c>.NativeClassPtr, "<>9__48_0");
				TrashManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager.__c>.NativeClassPtr, 100678140);
				TrashManager.__c.NativeMethodInfoPtr__GetRandomGeneratableTrashPrefab_b__48_0_Internal_Single_TrashItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager.__c>.NativeClassPtr, 100678141);
			}

			// Token: 0x0600D294 RID: 53908 RVA: 0x00325D64 File Offset: 0x00323F64
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashManager.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D295 RID: 53909 RVA: 0x00325DA0 File Offset: 0x00323FA0
			[CallerCount(0)]
			public unsafe float _GetRandomGeneratableTrashPrefab_b__48_0(TrashManager.TrashItemData t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.__c.NativeMethodInfoPtr__GetRandomGeneratableTrashPrefab_b__48_0_Internal_Single_TrashItemData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D296 RID: 53910 RVA: 0x0006680F File Offset: 0x00064A0F
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004154 RID: 16724
			// (get) Token: 0x0600D297 RID: 53911 RVA: 0x00325DF0 File Offset: 0x00323FF0
			// (set) Token: 0x0600D298 RID: 53912 RVA: 0x00066818 File Offset: 0x00064A18
			public unsafe static TrashManager.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TrashManager.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashManager.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TrashManager.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004155 RID: 16725
			// (get) Token: 0x0600D299 RID: 53913 RVA: 0x00325E18 File Offset: 0x00324018
			// (set) Token: 0x0600D29A RID: 53914 RVA: 0x0006682A File Offset: 0x00064A2A
			public unsafe static Func<TrashManager.TrashItemData, float> __9__48_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TrashManager.__c.NativeFieldInfoPtr___9__48_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TrashManager.TrashItemData, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TrashManager.__c.NativeFieldInfoPtr___9__48_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008DF9 RID: 36345
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008DFA RID: 36346
			private static readonly IntPtr NativeFieldInfoPtr___9__48_0;

			// Token: 0x04008DFB RID: 36347
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008DFC RID: 36348
			private static readonly IntPtr NativeMethodInfoPtr__GetRandomGeneratableTrashPrefab_b__48_0_Internal_Single_TrashItemData_0;
		}

		// Token: 0x02000A94 RID: 2708
		[ObfuscatedName("ScheduleOne.Trash.TrashManager+<>c__DisplayClass47_0")]
		public sealed class __c__DisplayClass47_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D29B RID: 53915 RVA: 0x00325E40 File Offset: 0x00324040
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass47_0()
			{
				Il2CppClassPointerStore<TrashManager.__c__DisplayClass47_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TrashManager>.NativeClassPtr, "<>c__DisplayClass47_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashManager.__c__DisplayClass47_0>.NativeClassPtr);
				TrashManager.__c__DisplayClass47_0.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashManager.__c__DisplayClass47_0>.NativeClassPtr, "id");
				TrashManager.__c__DisplayClass47_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager.__c__DisplayClass47_0>.NativeClassPtr, 100678142);
				TrashManager.__c__DisplayClass47_0.NativeMethodInfoPtr__GetTrashPrefab_b__0_Internal_Boolean_TrashItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashManager.__c__DisplayClass47_0>.NativeClassPtr, 100678143);
			}

			// Token: 0x0600D29C RID: 53916 RVA: 0x00325EA8 File Offset: 0x003240A8
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass47_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashManager.__c__DisplayClass47_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.__c__DisplayClass47_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D29D RID: 53917 RVA: 0x00325EE4 File Offset: 0x003240E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228936, XrefRangeEnd = 228938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetTrashPrefab_b__0(TrashItem t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashManager.__c__DisplayClass47_0.NativeMethodInfoPtr__GetTrashPrefab_b__0_Internal_Boolean_TrashItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D29E RID: 53918 RVA: 0x0006683C File Offset: 0x00064A3C
			public __c__DisplayClass47_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004156 RID: 16726
			// (get) Token: 0x0600D29F RID: 53919 RVA: 0x00325F34 File Offset: 0x00324134
			// (set) Token: 0x0600D2A0 RID: 53920 RVA: 0x00066845 File Offset: 0x00064A45
			public unsafe string id
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashManager.__c__DisplayClass47_0.NativeFieldInfoPtr_id);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashManager.__c__DisplayClass47_0.NativeFieldInfoPtr_id), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008DFD RID: 36349
			private static readonly IntPtr NativeFieldInfoPtr_id;

			// Token: 0x04008DFE RID: 36350
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008DFF RID: 36351
			private static readonly IntPtr NativeMethodInfoPtr__GetTrashPrefab_b__0_Internal_Boolean_TrashItem_0;
		}
	}
}
