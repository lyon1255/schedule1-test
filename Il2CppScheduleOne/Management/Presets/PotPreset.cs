using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management.Presets.Options;

namespace Il2CppScheduleOne.Management.Presets
{
	// Token: 0x020003AB RID: 939
	public class PotPreset : Preset
	{
		// Token: 0x0600496C RID: 18796 RVA: 0x00165E40 File Offset: 0x00164040
		// Note: this type is marked as 'beforefieldinit'.
		static PotPreset()
		{
			Il2CppClassPointerStore<PotPreset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management.Presets", "PotPreset");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PotPreset>.NativeClassPtr);
			PotPreset.NativeFieldInfoPtr__DefaultPreset_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotPreset>.NativeClassPtr, "<DefaultPreset>k__BackingField");
			PotPreset.NativeFieldInfoPtr_Seeds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotPreset>.NativeClassPtr, "Seeds");
			PotPreset.NativeFieldInfoPtr_Additives = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotPreset>.NativeClassPtr, "Additives");
			PotPreset.NativeMethodInfoPtr_get_DefaultPreset_Protected_Static_get_PotPreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotPreset>.NativeClassPtr, 100672408);
			PotPreset.NativeMethodInfoPtr_set_DefaultPreset_Protected_Static_set_Void_PotPreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotPreset>.NativeClassPtr, 100672409);
			PotPreset.NativeMethodInfoPtr_GetCopy_Public_Virtual_Preset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotPreset>.NativeClassPtr, 100672410);
			PotPreset.NativeMethodInfoPtr_CopyTo_Public_Virtual_Void_Preset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotPreset>.NativeClassPtr, 100672411);
			PotPreset.NativeMethodInfoPtr_InitializeOptions_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotPreset>.NativeClassPtr, 100672412);
			PotPreset.NativeMethodInfoPtr_GetDefaultPreset_Public_Static_PotPreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotPreset>.NativeClassPtr, 100672413);
			PotPreset.NativeMethodInfoPtr_GetNewBlankPreset_Public_Static_PotPreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotPreset>.NativeClassPtr, 100672414);
			PotPreset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotPreset>.NativeClassPtr, 100672415);
		}

		// Token: 0x17001607 RID: 5639
		// (get) Token: 0x0600496D RID: 18797 RVA: 0x00165F4C File Offset: 0x0016414C
		// (set) Token: 0x0600496E RID: 18798 RVA: 0x00165F80 File Offset: 0x00164180
		public unsafe static PotPreset DefaultPreset
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163343, XrefRangeEnd = 163345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotPreset.NativeMethodInfoPtr_get_DefaultPreset_Protected_Static_get_PotPreset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PotPreset>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163345, XrefRangeEnd = 163349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotPreset.NativeMethodInfoPtr_set_DefaultPreset_Protected_Static_set_Void_PotPreset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600496F RID: 18799 RVA: 0x00165FB8 File Offset: 0x001641B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163349, XrefRangeEnd = 163353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Preset GetCopy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PotPreset.NativeMethodInfoPtr_GetCopy_Public_Virtual_Preset_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Preset>(intPtr3) : null;
		}

		// Token: 0x06004970 RID: 18800 RVA: 0x00166004 File Offset: 0x00164204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163353, XrefRangeEnd = 163356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CopyTo(Preset other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PotPreset.NativeMethodInfoPtr_CopyTo_Public_Virtual_Void_Preset_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004971 RID: 18801 RVA: 0x00166054 File Offset: 0x00164254
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163356, XrefRangeEnd = 163377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitializeOptions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PotPreset.NativeMethodInfoPtr_InitializeOptions_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004972 RID: 18802 RVA: 0x00166090 File Offset: 0x00164290
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 163393, RefRangeEnd = 163394, XrefRangeStart = 163377, XrefRangeEnd = 163393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PotPreset GetDefaultPreset()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotPreset.NativeMethodInfoPtr_GetDefaultPreset_Public_Static_PotPreset_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PotPreset>(intPtr3) : null;
		}

		// Token: 0x06004973 RID: 18803 RVA: 0x001660C4 File Offset: 0x001642C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163394, XrefRangeEnd = 163416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PotPreset GetNewBlankPreset()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotPreset.NativeMethodInfoPtr_GetNewBlankPreset_Public_Static_PotPreset_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PotPreset>(intPtr3) : null;
		}

		// Token: 0x06004974 RID: 18804 RVA: 0x001660F8 File Offset: 0x001642F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163416, XrefRangeEnd = 163417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PotPreset() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PotPreset>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotPreset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004975 RID: 18805 RVA: 0x000235DD File Offset: 0x000217DD
		public PotPreset(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001604 RID: 5636
		// (get) Token: 0x06004976 RID: 18806 RVA: 0x00166134 File Offset: 0x00164334
		// (set) Token: 0x06004977 RID: 18807 RVA: 0x000235E6 File Offset: 0x000217E6
		public unsafe static PotPreset _DefaultPreset_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PotPreset.NativeFieldInfoPtr__DefaultPreset_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PotPreset>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PotPreset.NativeFieldInfoPtr__DefaultPreset_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001605 RID: 5637
		// (get) Token: 0x06004978 RID: 18808 RVA: 0x0016615C File Offset: 0x0016435C
		// (set) Token: 0x06004979 RID: 18809 RVA: 0x000235F8 File Offset: 0x000217F8
		public unsafe ItemList Seeds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotPreset.NativeFieldInfoPtr_Seeds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotPreset.NativeFieldInfoPtr_Seeds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001606 RID: 5638
		// (get) Token: 0x0600497A RID: 18810 RVA: 0x0016618C File Offset: 0x0016438C
		// (set) Token: 0x0600497B RID: 18811 RVA: 0x00023617 File Offset: 0x00021817
		public unsafe ItemList Additives
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotPreset.NativeFieldInfoPtr_Additives);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotPreset.NativeFieldInfoPtr_Additives), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003188 RID: 12680
		private static readonly IntPtr NativeFieldInfoPtr__DefaultPreset_k__BackingField;

		// Token: 0x04003189 RID: 12681
		private static readonly IntPtr NativeFieldInfoPtr_Seeds;

		// Token: 0x0400318A RID: 12682
		private static readonly IntPtr NativeFieldInfoPtr_Additives;

		// Token: 0x0400318B RID: 12683
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultPreset_Protected_Static_get_PotPreset_0;

		// Token: 0x0400318C RID: 12684
		private static readonly IntPtr NativeMethodInfoPtr_set_DefaultPreset_Protected_Static_set_Void_PotPreset_0;

		// Token: 0x0400318D RID: 12685
		private static readonly IntPtr NativeMethodInfoPtr_GetCopy_Public_Virtual_Preset_0;

		// Token: 0x0400318E RID: 12686
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Void_Preset_0;

		// Token: 0x0400318F RID: 12687
		private static readonly IntPtr NativeMethodInfoPtr_InitializeOptions_Public_Virtual_Void_0;

		// Token: 0x04003190 RID: 12688
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultPreset_Public_Static_PotPreset_0;

		// Token: 0x04003191 RID: 12689
		private static readonly IntPtr NativeMethodInfoPtr_GetNewBlankPreset_Public_Static_PotPreset_0;

		// Token: 0x04003192 RID: 12690
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
