using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Persistence;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Trash
{
	// Token: 0x0200051D RID: 1309
	public class TrashContainer : NetworkBehaviour
	{
		// Token: 0x06007487 RID: 29831 RVA: 0x001FBC3C File Offset: 0x001F9E3C
		// Note: this type is marked as 'beforefieldinit'.
		static TrashContainer()
		{
			Il2CppClassPointerStore<TrashContainer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Trash", "TrashContainer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr);
			TrashContainer.NativeFieldInfoPtr__Content_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, "<Content>k__BackingField");
			TrashContainer.NativeFieldInfoPtr_TrashCapacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, "TrashCapacity");
			TrashContainer.NativeFieldInfoPtr_TrashBagDropLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, "TrashBagDropLocation");
			TrashContainer.NativeFieldInfoPtr_onTrashAdded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, "onTrashAdded");
			TrashContainer.NativeFieldInfoPtr_onTrashLevelChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, "onTrashLevelChanged");
			TrashContainer.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Trash.TrashContainerAssembly-CSharp.dll_Excuted");
			TrashContainer.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Trash.TrashContainerAssembly-CSharp.dll_Excuted");
			TrashContainer.NativeMethodInfoPtr_get_Content_Public_get_TrashContent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100677941);
			TrashContainer.NativeMethodInfoPtr_set_Content_Protected_set_Void_TrashContent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100677942);
			TrashContainer.NativeMethodInfoPtr_get_TrashLevel_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100677943);
			TrashContainer.NativeMethodInfoPtr_get_NormalizedTrashLevel_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100677944);
			TrashContainer.NativeMethodInfoPtr_AddTrash_Public_Virtual_New_Void_TrashItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100677945);
			TrashContainer.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100677946);
			TrashContainer.NativeMethodInfoPtr_SendTrash_Private_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100677947);
			TrashContainer.NativeMethodInfoPtr_AddTrash_Private_Void_NetworkConnection_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100677948);
			TrashContainer.NativeMethodInfoPtr_SendClear_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100677949);
			TrashContainer.NativeMethodInfoPtr_Clear_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100677950);
			TrashContainer.NativeMethodInfoPtr_LoadContent_Private_Void_NetworkConnection_TrashContentData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100677951);
			TrashContainer.NativeMethodInfoPtr_TriggerEnter_Public_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100677952);
			TrashContainer.NativeMethodInfoPtr_CanBeBagged_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100677953);
			TrashContainer.NativeMethodInfoPtr_BagTrash_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100677954);
			TrashContainer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100677955);
			TrashContainer.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100677956);
			TrashContainer.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100677957);
			TrashContainer.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100677958);
			TrashContainer.NativeMethodInfoPtr_RpcWriter___Server_SendTrash_3643459082_Private_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100677959);
			TrashContainer.NativeMethodInfoPtr_RpcLogic___SendTrash_3643459082_Private_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100677960);
			TrashContainer.NativeMethodInfoPtr_RpcReader___Server_SendTrash_3643459082_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100677961);
			TrashContainer.NativeMethodInfoPtr_RpcWriter___Observers_AddTrash_3905681115_Private_Void_NetworkConnection_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100677962);
			TrashContainer.NativeMethodInfoPtr_RpcLogic___AddTrash_3905681115_Private_Void_NetworkConnection_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100677963);
			TrashContainer.NativeMethodInfoPtr_RpcReader___Observers_AddTrash_3905681115_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100677964);
			TrashContainer.NativeMethodInfoPtr_RpcWriter___Target_AddTrash_3905681115_Private_Void_NetworkConnection_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100677965);
			TrashContainer.NativeMethodInfoPtr_RpcReader___Target_AddTrash_3905681115_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100677966);
			TrashContainer.NativeMethodInfoPtr_RpcWriter___Server_SendClear_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100677967);
			TrashContainer.NativeMethodInfoPtr_RpcLogic___SendClear_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100677968);
			TrashContainer.NativeMethodInfoPtr_RpcReader___Server_SendClear_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100677969);
			TrashContainer.NativeMethodInfoPtr_RpcWriter___Observers_Clear_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100677970);
			TrashContainer.NativeMethodInfoPtr_RpcLogic___Clear_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100677971);
			TrashContainer.NativeMethodInfoPtr_RpcReader___Observers_Clear_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100677972);
			TrashContainer.NativeMethodInfoPtr_RpcWriter___Target_LoadContent_189522235_Private_Void_NetworkConnection_TrashContentData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100677973);
			TrashContainer.NativeMethodInfoPtr_RpcLogic___LoadContent_189522235_Private_Void_NetworkConnection_TrashContentData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100677974);
			TrashContainer.NativeMethodInfoPtr_RpcReader___Target_LoadContent_189522235_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100677975);
			TrashContainer.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr, 100677976);
		}

		// Token: 0x17002359 RID: 9049
		// (get) Token: 0x06007488 RID: 29832 RVA: 0x001FBFC8 File Offset: 0x001FA1C8
		// (set) Token: 0x06007489 RID: 29833 RVA: 0x001FC008 File Offset: 0x001FA208
		public unsafe TrashContent Content
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_get_Content_Public_get_TrashContent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TrashContent>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_set_Content_Protected_set_Void_TrashContent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700235A RID: 9050
		// (get) Token: 0x0600748A RID: 29834 RVA: 0x001FC04C File Offset: 0x001FA24C
		public unsafe int TrashLevel
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 227600, RefRangeEnd = 227601, XrefRangeStart = 227598, XrefRangeEnd = 227600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_get_TrashLevel_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700235B RID: 9051
		// (get) Token: 0x0600748B RID: 29835 RVA: 0x001FC088 File Offset: 0x001FA288
		public unsafe float NormalizedTrashLevel
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 227602, RefRangeEnd = 227606, XrefRangeStart = 227601, XrefRangeEnd = 227602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_get_NormalizedTrashLevel_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600748C RID: 29836 RVA: 0x001FC0C4 File Offset: 0x001FA2C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227606, XrefRangeEnd = 227646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AddTrash(TrashItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashContainer.NativeMethodInfoPtr_AddTrash_Public_Virtual_New_Void_TrashItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600748D RID: 29837 RVA: 0x001FC114 File Offset: 0x001FA314
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227646, XrefRangeEnd = 227659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashContainer.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600748E RID: 29838 RVA: 0x001FC164 File Offset: 0x001FA364
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227659, XrefRangeEnd = 227682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendTrash(string trashID, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(trashID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_SendTrash_Private_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600748F RID: 29839 RVA: 0x001FC1B4 File Offset: 0x001FA3B4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 227728, RefRangeEnd = 227732, XrefRangeStart = 227682, XrefRangeEnd = 227728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddTrash(NetworkConnection conn, string trashID, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(trashID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_AddTrash_Private_Void_NetworkConnection_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007490 RID: 29840 RVA: 0x001FC218 File Offset: 0x001FA418
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227732, XrefRangeEnd = 227753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendClear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_SendClear_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007491 RID: 29841 RVA: 0x001FC24C File Offset: 0x001FA44C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 227774, RefRangeEnd = 227777, XrefRangeStart = 227753, XrefRangeEnd = 227774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_Clear_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007492 RID: 29842 RVA: 0x001FC280 File Offset: 0x001FA480
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227777, XrefRangeEnd = 227796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadContent(NetworkConnection conn, TrashContentData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_LoadContent_Private_Void_NetworkConnection_TrashContentData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007493 RID: 29843 RVA: 0x001FC2D4 File Offset: 0x001FA4D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227796, XrefRangeEnd = 227805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TriggerEnter(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_TriggerEnter_Public_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007494 RID: 29844 RVA: 0x001FC318 File Offset: 0x001FA518
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227805, XrefRangeEnd = 227806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanBeBagged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_CanBeBagged_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007495 RID: 29845 RVA: 0x001FC354 File Offset: 0x001FA554
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 227855, RefRangeEnd = 227856, XrefRangeStart = 227806, XrefRangeEnd = 227855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BagTrash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_BagTrash_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007496 RID: 29846 RVA: 0x001FC388 File Offset: 0x001FA588
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227856, XrefRangeEnd = 227862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashContainer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashContainer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007497 RID: 29847 RVA: 0x001FC3C4 File Offset: 0x001FA5C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227862, XrefRangeEnd = 227900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashContainer.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007498 RID: 29848 RVA: 0x001FC400 File Offset: 0x001FA600
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 208856, RefRangeEnd = 208857, XrefRangeStart = 208856, XrefRangeEnd = 208857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashContainer.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007499 RID: 29849 RVA: 0x001FC43C File Offset: 0x001FA63C
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashContainer.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600749A RID: 29850 RVA: 0x001FC478 File Offset: 0x001FA678
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227900, XrefRangeEnd = 227921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendTrash_3643459082(string trashID, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(trashID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_RpcWriter___Server_SendTrash_3643459082_Private_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600749B RID: 29851 RVA: 0x001FC4C8 File Offset: 0x001FA6C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227921, XrefRangeEnd = 227922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendTrash_3643459082(string trashID, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(trashID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_RpcLogic___SendTrash_3643459082_Private_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600749C RID: 29852 RVA: 0x001FC518 File Offset: 0x001FA718
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227922, XrefRangeEnd = 227928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendTrash_3643459082(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_RpcReader___Server_SendTrash_3643459082_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600749D RID: 29853 RVA: 0x001FC57C File Offset: 0x001FA77C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227928, XrefRangeEnd = 227949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_AddTrash_3905681115(NetworkConnection conn, string trashID, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(trashID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_RpcWriter___Observers_AddTrash_3905681115_Private_Void_NetworkConnection_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600749E RID: 29854 RVA: 0x001FC5E0 File Offset: 0x001FA7E0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 227954, RefRangeEnd = 227957, XrefRangeStart = 227949, XrefRangeEnd = 227954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___AddTrash_3905681115(NetworkConnection conn, string trashID, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(trashID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_RpcLogic___AddTrash_3905681115_Private_Void_NetworkConnection_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600749F RID: 29855 RVA: 0x001FC644 File Offset: 0x001FA844
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227957, XrefRangeEnd = 227963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_AddTrash_3905681115(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_RpcReader___Observers_AddTrash_3905681115_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074A0 RID: 29856 RVA: 0x001FC694 File Offset: 0x001FA894
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227963, XrefRangeEnd = 227975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_AddTrash_3905681115(NetworkConnection conn, string trashID, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(trashID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_RpcWriter___Target_AddTrash_3905681115_Private_Void_NetworkConnection_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074A1 RID: 29857 RVA: 0x001FC6F8 File Offset: 0x001FA8F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227975, XrefRangeEnd = 227981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_AddTrash_3905681115(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_RpcReader___Target_AddTrash_3905681115_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074A2 RID: 29858 RVA: 0x001FC748 File Offset: 0x001FA948
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227981, XrefRangeEnd = 227999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendClear_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_RpcWriter___Server_SendClear_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074A3 RID: 29859 RVA: 0x001FC77C File Offset: 0x001FA97C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 227774, RefRangeEnd = 227777, XrefRangeStart = 227774, XrefRangeEnd = 227777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendClear_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_RpcLogic___SendClear_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074A4 RID: 29860 RVA: 0x001FC7B0 File Offset: 0x001FA9B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227999, XrefRangeEnd = 228002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendClear_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_RpcReader___Server_SendClear_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074A5 RID: 29861 RVA: 0x001FC814 File Offset: 0x001FAA14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228002, XrefRangeEnd = 228020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_Clear_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_RpcWriter___Observers_Clear_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074A6 RID: 29862 RVA: 0x001FC848 File Offset: 0x001FAA48
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 228023, RefRangeEnd = 228026, XrefRangeStart = 228020, XrefRangeEnd = 228023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___Clear_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_RpcLogic___Clear_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074A7 RID: 29863 RVA: 0x001FC87C File Offset: 0x001FAA7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228026, XrefRangeEnd = 228029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_Clear_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_RpcReader___Observers_Clear_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074A8 RID: 29864 RVA: 0x001FC8CC File Offset: 0x001FAACC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_LoadContent_189522235(NetworkConnection conn, TrashContentData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_RpcWriter___Target_LoadContent_189522235_Private_Void_NetworkConnection_TrashContentData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074A9 RID: 29865 RVA: 0x001FC920 File Offset: 0x001FAB20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228029, XrefRangeEnd = 228032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___LoadContent_189522235(NetworkConnection conn, TrashContentData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_RpcLogic___LoadContent_189522235_Private_Void_NetworkConnection_TrashContentData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074AA RID: 29866 RVA: 0x001FC974 File Offset: 0x001FAB74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228032, XrefRangeEnd = 228038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_LoadContent_189522235(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainer.NativeMethodInfoPtr_RpcReader___Target_LoadContent_189522235_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074AB RID: 29867 RVA: 0x001FC9C4 File Offset: 0x001FABC4
		[CallerCount(0)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashContainer.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074AC RID: 29868 RVA: 0x0003755F File Offset: 0x0003575F
		public TrashContainer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002352 RID: 9042
		// (get) Token: 0x060074AD RID: 29869 RVA: 0x001FCA00 File Offset: 0x001FAC00
		// (set) Token: 0x060074AE RID: 29870 RVA: 0x00037568 File Offset: 0x00035768
		public unsafe TrashContent _Content_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainer.NativeFieldInfoPtr__Content_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashContent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainer.NativeFieldInfoPtr__Content_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002353 RID: 9043
		// (get) Token: 0x060074AF RID: 29871 RVA: 0x001FCA30 File Offset: 0x001FAC30
		// (set) Token: 0x060074B0 RID: 29872 RVA: 0x00037587 File Offset: 0x00035787
		public unsafe int TrashCapacity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainer.NativeFieldInfoPtr_TrashCapacity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainer.NativeFieldInfoPtr_TrashCapacity)) = value;
			}
		}

		// Token: 0x17002354 RID: 9044
		// (get) Token: 0x060074B1 RID: 29873 RVA: 0x001FCA58 File Offset: 0x001FAC58
		// (set) Token: 0x060074B2 RID: 29874 RVA: 0x000375A2 File Offset: 0x000357A2
		public unsafe Transform TrashBagDropLocation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainer.NativeFieldInfoPtr_TrashBagDropLocation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainer.NativeFieldInfoPtr_TrashBagDropLocation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002355 RID: 9045
		// (get) Token: 0x060074B3 RID: 29875 RVA: 0x001FCA88 File Offset: 0x001FAC88
		// (set) Token: 0x060074B4 RID: 29876 RVA: 0x000375C1 File Offset: 0x000357C1
		public unsafe UnityEvent<string> onTrashAdded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainer.NativeFieldInfoPtr_onTrashAdded);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainer.NativeFieldInfoPtr_onTrashAdded), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002356 RID: 9046
		// (get) Token: 0x060074B5 RID: 29877 RVA: 0x001FCAB8 File Offset: 0x001FACB8
		// (set) Token: 0x060074B6 RID: 29878 RVA: 0x000375E0 File Offset: 0x000357E0
		public unsafe UnityEvent onTrashLevelChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainer.NativeFieldInfoPtr_onTrashLevelChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainer.NativeFieldInfoPtr_onTrashLevelChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002357 RID: 9047
		// (get) Token: 0x060074B7 RID: 29879 RVA: 0x001FCAE8 File Offset: 0x001FACE8
		// (set) Token: 0x060074B8 RID: 29880 RVA: 0x000375FF File Offset: 0x000357FF
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainer.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainer.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17002358 RID: 9048
		// (get) Token: 0x060074B9 RID: 29881 RVA: 0x001FCB10 File Offset: 0x001FAD10
		// (set) Token: 0x060074BA RID: 29882 RVA: 0x0003761A File Offset: 0x0003581A
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainer.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainer.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04004F8F RID: 20367
		private static readonly IntPtr NativeFieldInfoPtr__Content_k__BackingField;

		// Token: 0x04004F90 RID: 20368
		private static readonly IntPtr NativeFieldInfoPtr_TrashCapacity;

		// Token: 0x04004F91 RID: 20369
		private static readonly IntPtr NativeFieldInfoPtr_TrashBagDropLocation;

		// Token: 0x04004F92 RID: 20370
		private static readonly IntPtr NativeFieldInfoPtr_onTrashAdded;

		// Token: 0x04004F93 RID: 20371
		private static readonly IntPtr NativeFieldInfoPtr_onTrashLevelChanged;

		// Token: 0x04004F94 RID: 20372
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04004F95 RID: 20373
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04004F96 RID: 20374
		private static readonly IntPtr NativeMethodInfoPtr_get_Content_Public_get_TrashContent_0;

		// Token: 0x04004F97 RID: 20375
		private static readonly IntPtr NativeMethodInfoPtr_set_Content_Protected_set_Void_TrashContent_0;

		// Token: 0x04004F98 RID: 20376
		private static readonly IntPtr NativeMethodInfoPtr_get_TrashLevel_Public_get_Int32_0;

		// Token: 0x04004F99 RID: 20377
		private static readonly IntPtr NativeMethodInfoPtr_get_NormalizedTrashLevel_Public_get_Single_0;

		// Token: 0x04004F9A RID: 20378
		private static readonly IntPtr NativeMethodInfoPtr_AddTrash_Public_Virtual_New_Void_TrashItem_0;

		// Token: 0x04004F9B RID: 20379
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04004F9C RID: 20380
		private static readonly IntPtr NativeMethodInfoPtr_SendTrash_Private_Void_String_Int32_0;

		// Token: 0x04004F9D RID: 20381
		private static readonly IntPtr NativeMethodInfoPtr_AddTrash_Private_Void_NetworkConnection_String_Int32_0;

		// Token: 0x04004F9E RID: 20382
		private static readonly IntPtr NativeMethodInfoPtr_SendClear_Private_Void_0;

		// Token: 0x04004F9F RID: 20383
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Private_Void_0;

		// Token: 0x04004FA0 RID: 20384
		private static readonly IntPtr NativeMethodInfoPtr_LoadContent_Private_Void_NetworkConnection_TrashContentData_0;

		// Token: 0x04004FA1 RID: 20385
		private static readonly IntPtr NativeMethodInfoPtr_TriggerEnter_Public_Void_Collider_0;

		// Token: 0x04004FA2 RID: 20386
		private static readonly IntPtr NativeMethodInfoPtr_CanBeBagged_Public_Boolean_0;

		// Token: 0x04004FA3 RID: 20387
		private static readonly IntPtr NativeMethodInfoPtr_BagTrash_Public_Void_0;

		// Token: 0x04004FA4 RID: 20388
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004FA5 RID: 20389
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04004FA6 RID: 20390
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04004FA7 RID: 20391
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04004FA8 RID: 20392
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendTrash_3643459082_Private_Void_String_Int32_0;

		// Token: 0x04004FA9 RID: 20393
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendTrash_3643459082_Private_Void_String_Int32_0;

		// Token: 0x04004FAA RID: 20394
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendTrash_3643459082_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04004FAB RID: 20395
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_AddTrash_3905681115_Private_Void_NetworkConnection_String_Int32_0;

		// Token: 0x04004FAC RID: 20396
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___AddTrash_3905681115_Private_Void_NetworkConnection_String_Int32_0;

		// Token: 0x04004FAD RID: 20397
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_AddTrash_3905681115_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004FAE RID: 20398
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_AddTrash_3905681115_Private_Void_NetworkConnection_String_Int32_0;

		// Token: 0x04004FAF RID: 20399
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_AddTrash_3905681115_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004FB0 RID: 20400
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendClear_2166136261_Private_Void_0;

		// Token: 0x04004FB1 RID: 20401
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendClear_2166136261_Private_Void_0;

		// Token: 0x04004FB2 RID: 20402
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendClear_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04004FB3 RID: 20403
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_Clear_2166136261_Private_Void_0;

		// Token: 0x04004FB4 RID: 20404
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___Clear_2166136261_Private_Void_0;

		// Token: 0x04004FB5 RID: 20405
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_Clear_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004FB6 RID: 20406
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_LoadContent_189522235_Private_Void_NetworkConnection_TrashContentData_0;

		// Token: 0x04004FB7 RID: 20407
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___LoadContent_189522235_Private_Void_NetworkConnection_TrashContentData_0;

		// Token: 0x04004FB8 RID: 20408
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_LoadContent_189522235_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004FB9 RID: 20409
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
