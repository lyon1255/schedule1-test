using System;
using Il2CppFishNet.Connection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Police;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x020003C1 RID: 961
	public class CheckpointManager : NetworkSingleton<CheckpointManager>
	{
		// Token: 0x06004AF0 RID: 19184 RVA: 0x0016AD54 File Offset: 0x00168F54
		// Note: this type is marked as 'beforefieldinit'.
		static CheckpointManager()
		{
			Il2CppClassPointerStore<CheckpointManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "CheckpointManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CheckpointManager>.NativeClassPtr);
			CheckpointManager.NativeFieldInfoPtr_WesternCheckpoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointManager>.NativeClassPtr, "WesternCheckpoint");
			CheckpointManager.NativeFieldInfoPtr_DocksCheckpoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointManager>.NativeClassPtr, "DocksCheckpoint");
			CheckpointManager.NativeFieldInfoPtr_NorthResidentialCheckpoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointManager>.NativeClassPtr, "NorthResidentialCheckpoint");
			CheckpointManager.NativeFieldInfoPtr_WestResidentialCheckpoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointManager>.NativeClassPtr, "WestResidentialCheckpoint");
			CheckpointManager.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointManager>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Law.CheckpointManagerAssembly-CSharp.dll_Excuted");
			CheckpointManager.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckpointManager>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Law.CheckpointManagerAssembly-CSharp.dll_Excuted");
			CheckpointManager.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointManager>.NativeClassPtr, 100672589);
			CheckpointManager.NativeMethodInfoPtr_SetCheckpointEnabled_Public_Void_ECheckpointLocation_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointManager>.NativeClassPtr, 100672590);
			CheckpointManager.NativeMethodInfoPtr_GetCheckpoint_Public_RoadCheckpoint_ECheckpointLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointManager>.NativeClassPtr, 100672591);
			CheckpointManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointManager>.NativeClassPtr, 100672592);
			CheckpointManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointManager>.NativeClassPtr, 100672593);
			CheckpointManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointManager>.NativeClassPtr, 100672594);
			CheckpointManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointManager>.NativeClassPtr, 100672595);
			CheckpointManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckpointManager>.NativeClassPtr, 100672596);
		}

		// Token: 0x06004AF1 RID: 19185 RVA: 0x0016AE9C File Offset: 0x0016909C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164568, XrefRangeEnd = 164573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CheckpointManager.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004AF2 RID: 19186 RVA: 0x0016AEEC File Offset: 0x001690EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 164579, RefRangeEnd = 164580, XrefRangeStart = 164573, XrefRangeEnd = 164579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCheckpointEnabled(CheckpointManager.ECheckpointLocation checkpoint, bool enabled, int requestedOfficers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref checkpoint;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enabled;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref requestedOfficers;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointManager.NativeMethodInfoPtr_SetCheckpointEnabled_Public_Void_ECheckpointLocation_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004AF3 RID: 19187 RVA: 0x0016AF48 File Offset: 0x00169148
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 164580, RefRangeEnd = 164583, XrefRangeStart = 164580, XrefRangeEnd = 164580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RoadCheckpoint GetCheckpoint(CheckpointManager.ECheckpointLocation loc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref loc;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointManager.NativeMethodInfoPtr_GetCheckpoint_Public_RoadCheckpoint_ECheckpointLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RoadCheckpoint>(intPtr3) : null;
		}

		// Token: 0x06004AF4 RID: 19188 RVA: 0x0016AF94 File Offset: 0x00169194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164583, XrefRangeEnd = 164586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CheckpointManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CheckpointManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckpointManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004AF5 RID: 19189 RVA: 0x0016AFD0 File Offset: 0x001691D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164586, XrefRangeEnd = 164589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CheckpointManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004AF6 RID: 19190 RVA: 0x0016B00C File Offset: 0x0016920C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164589, XrefRangeEnd = 164592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CheckpointManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004AF7 RID: 19191 RVA: 0x0016B048 File Offset: 0x00169248
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CheckpointManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004AF8 RID: 19192 RVA: 0x0016B084 File Offset: 0x00169284
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164592, XrefRangeEnd = 164595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CheckpointManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004AF9 RID: 19193 RVA: 0x00024174 File Offset: 0x00022374
		public CheckpointManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001677 RID: 5751
		// (get) Token: 0x06004AFA RID: 19194 RVA: 0x0016B0C0 File Offset: 0x001692C0
		// (set) Token: 0x06004AFB RID: 19195 RVA: 0x0002417D File Offset: 0x0002237D
		public unsafe RoadCheckpoint WesternCheckpoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointManager.NativeFieldInfoPtr_WesternCheckpoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RoadCheckpoint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointManager.NativeFieldInfoPtr_WesternCheckpoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001678 RID: 5752
		// (get) Token: 0x06004AFC RID: 19196 RVA: 0x0016B0F0 File Offset: 0x001692F0
		// (set) Token: 0x06004AFD RID: 19197 RVA: 0x0002419C File Offset: 0x0002239C
		public unsafe RoadCheckpoint DocksCheckpoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointManager.NativeFieldInfoPtr_DocksCheckpoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RoadCheckpoint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointManager.NativeFieldInfoPtr_DocksCheckpoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001679 RID: 5753
		// (get) Token: 0x06004AFE RID: 19198 RVA: 0x0016B120 File Offset: 0x00169320
		// (set) Token: 0x06004AFF RID: 19199 RVA: 0x000241BB File Offset: 0x000223BB
		public unsafe RoadCheckpoint NorthResidentialCheckpoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointManager.NativeFieldInfoPtr_NorthResidentialCheckpoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RoadCheckpoint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointManager.NativeFieldInfoPtr_NorthResidentialCheckpoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700167A RID: 5754
		// (get) Token: 0x06004B00 RID: 19200 RVA: 0x0016B150 File Offset: 0x00169350
		// (set) Token: 0x06004B01 RID: 19201 RVA: 0x000241DA File Offset: 0x000223DA
		public unsafe RoadCheckpoint WestResidentialCheckpoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointManager.NativeFieldInfoPtr_WestResidentialCheckpoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RoadCheckpoint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointManager.NativeFieldInfoPtr_WestResidentialCheckpoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700167B RID: 5755
		// (get) Token: 0x06004B02 RID: 19202 RVA: 0x0016B180 File Offset: 0x00169380
		// (set) Token: 0x06004B03 RID: 19203 RVA: 0x000241F9 File Offset: 0x000223F9
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointManager.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointManager.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x1700167C RID: 5756
		// (get) Token: 0x06004B04 RID: 19204 RVA: 0x0016B1A8 File Offset: 0x001693A8
		// (set) Token: 0x06004B05 RID: 19205 RVA: 0x00024214 File Offset: 0x00022414
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointManager.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckpointManager.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04003291 RID: 12945
		private static readonly IntPtr NativeFieldInfoPtr_WesternCheckpoint;

		// Token: 0x04003292 RID: 12946
		private static readonly IntPtr NativeFieldInfoPtr_DocksCheckpoint;

		// Token: 0x04003293 RID: 12947
		private static readonly IntPtr NativeFieldInfoPtr_NorthResidentialCheckpoint;

		// Token: 0x04003294 RID: 12948
		private static readonly IntPtr NativeFieldInfoPtr_WestResidentialCheckpoint;

		// Token: 0x04003295 RID: 12949
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04003296 RID: 12950
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04003297 RID: 12951
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04003298 RID: 12952
		private static readonly IntPtr NativeMethodInfoPtr_SetCheckpointEnabled_Public_Void_ECheckpointLocation_Boolean_Int32_0;

		// Token: 0x04003299 RID: 12953
		private static readonly IntPtr NativeMethodInfoPtr_GetCheckpoint_Public_RoadCheckpoint_ECheckpointLocation_0;

		// Token: 0x0400329A RID: 12954
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400329B RID: 12955
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x0400329C RID: 12956
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x0400329D RID: 12957
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x0400329E RID: 12958
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x02000988 RID: 2440
		[OriginalName("Assembly-CSharp.dll", "", "ECheckpointLocation")]
		public enum ECheckpointLocation
		{
			// Token: 0x040088D4 RID: 35028
			Western,
			// Token: 0x040088D5 RID: 35029
			Docks,
			// Token: 0x040088D6 RID: 35030
			NorthResidential,
			// Token: 0x040088D7 RID: 35031
			WestResidential
		}
	}
}
