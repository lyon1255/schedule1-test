using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.PlayerTasks.Tasks;

namespace Il2CppScheduleOne.PlayerTasks
{
	// Token: 0x02000204 RID: 516
	public class ApplyAdditiveToPot : PourIntoPotTask
	{
		// Token: 0x06002ADB RID: 10971 RVA: 0x000F8178 File Offset: 0x000F6378
		// Note: this type is marked as 'beforefieldinit'.
		static ApplyAdditiveToPot()
		{
			Il2CppClassPointerStore<ApplyAdditiveToPot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerTasks", "ApplyAdditiveToPot");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ApplyAdditiveToPot>.NativeClassPtr);
			ApplyAdditiveToPot.NativeFieldInfoPtr_def = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyAdditiveToPot>.NativeClassPtr, "def");
			ApplyAdditiveToPot.NativeMethodInfoPtr_get_UseCoverage_Protected_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplyAdditiveToPot>.NativeClassPtr, 100668097);
			ApplyAdditiveToPot.NativeMethodInfoPtr_get_CameraPosition_Protected_Virtual_get_ECameraPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplyAdditiveToPot>.NativeClassPtr, 100668098);
			ApplyAdditiveToPot.NativeMethodInfoPtr__ctor_Public_Void_Pot_ItemInstance_Pourable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplyAdditiveToPot>.NativeClassPtr, 100668099);
			ApplyAdditiveToPot.NativeMethodInfoPtr_Update_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplyAdditiveToPot>.NativeClassPtr, 100668100);
			ApplyAdditiveToPot.NativeMethodInfoPtr_FullyCovered_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplyAdditiveToPot>.NativeClassPtr, 100668101);
		}

		// Token: 0x17000E48 RID: 3656
		// (get) Token: 0x06002ADC RID: 10972 RVA: 0x000F8220 File Offset: 0x000F6420
		public unsafe override bool UseCoverage
		{
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 30137, RefRangeEnd = 30157, XrefRangeStart = 30137, XrefRangeEnd = 30157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ApplyAdditiveToPot.NativeMethodInfoPtr_get_UseCoverage_Protected_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E49 RID: 3657
		// (get) Token: 0x06002ADD RID: 10973 RVA: 0x000F8268 File Offset: 0x000F6468
		public unsafe override Pot.ECameraPosition CameraPosition
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 120991, RefRangeEnd = 120996, XrefRangeStart = 120991, XrefRangeEnd = 120991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ApplyAdditiveToPot.NativeMethodInfoPtr_get_CameraPosition_Protected_Virtual_get_ECameraPosition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002ADE RID: 10974 RVA: 0x000F82B0 File Offset: 0x000F64B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 121014, RefRangeEnd = 121015, XrefRangeStart = 120996, XrefRangeEnd = 121014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ApplyAdditiveToPot(Pot _pot, ItemInstance _itemInstance, Pourable _pourablePrefab) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ApplyAdditiveToPot>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_pot);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_itemInstance);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_pourablePrefab);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApplyAdditiveToPot.NativeMethodInfoPtr__ctor_Public_Void_Pot_ItemInstance_Pourable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002ADF RID: 10975 RVA: 0x000F8320 File Offset: 0x000F6520
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121015, XrefRangeEnd = 121038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ApplyAdditiveToPot.NativeMethodInfoPtr_Update_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AE0 RID: 10976 RVA: 0x000F835C File Offset: 0x000F655C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121038, XrefRangeEnd = 121043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void FullyCovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ApplyAdditiveToPot.NativeMethodInfoPtr_FullyCovered_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AE1 RID: 10977 RVA: 0x000173D8 File Offset: 0x000155D8
		public ApplyAdditiveToPot(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000E47 RID: 3655
		// (get) Token: 0x06002AE2 RID: 10978 RVA: 0x000F8398 File Offset: 0x000F6598
		// (set) Token: 0x06002AE3 RID: 10979 RVA: 0x000173E1 File Offset: 0x000155E1
		public unsafe AdditiveDefinition def
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ApplyAdditiveToPot.NativeFieldInfoPtr_def);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdditiveDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ApplyAdditiveToPot.NativeFieldInfoPtr_def), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001C6D RID: 7277
		private static readonly IntPtr NativeFieldInfoPtr_def;

		// Token: 0x04001C6E RID: 7278
		private static readonly IntPtr NativeMethodInfoPtr_get_UseCoverage_Protected_Virtual_get_Boolean_0;

		// Token: 0x04001C6F RID: 7279
		private static readonly IntPtr NativeMethodInfoPtr_get_CameraPosition_Protected_Virtual_get_ECameraPosition_0;

		// Token: 0x04001C70 RID: 7280
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Pot_ItemInstance_Pourable_0;

		// Token: 0x04001C71 RID: 7281
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_0;

		// Token: 0x04001C72 RID: 7282
		private static readonly IntPtr NativeMethodInfoPtr_FullyCovered_Protected_Virtual_Void_0;
	}
}
