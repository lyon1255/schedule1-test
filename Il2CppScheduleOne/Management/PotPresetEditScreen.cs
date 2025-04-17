using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management.Presets;
using Il2CppScheduleOne.Management.Presets.Options;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x020003A0 RID: 928
	public class PotPresetEditScreen : PresetEditScreen
	{
		// Token: 0x060048AC RID: 18604 RVA: 0x00163554 File Offset: 0x00161754
		// Note: this type is marked as 'beforefieldinit'.
		static PotPresetEditScreen()
		{
			Il2CppClassPointerStore<PotPresetEditScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "PotPresetEditScreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PotPresetEditScreen>.NativeClassPtr);
			PotPresetEditScreen.NativeFieldInfoPtr_SeedsUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotPresetEditScreen>.NativeClassPtr, "SeedsUI");
			PotPresetEditScreen.NativeFieldInfoPtr_AdditivesUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotPresetEditScreen>.NativeClassPtr, "AdditivesUI");
			PotPresetEditScreen.NativeFieldInfoPtr_castedPreset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotPresetEditScreen>.NativeClassPtr, "castedPreset");
			PotPresetEditScreen.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotPresetEditScreen>.NativeClassPtr, 100672306);
			PotPresetEditScreen.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotPresetEditScreen>.NativeClassPtr, 100672307);
			PotPresetEditScreen.NativeMethodInfoPtr_Open_Public_Virtual_Void_Preset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotPresetEditScreen>.NativeClassPtr, 100672308);
			PotPresetEditScreen.NativeMethodInfoPtr_UpdateUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotPresetEditScreen>.NativeClassPtr, 100672309);
			PotPresetEditScreen.NativeMethodInfoPtr_SeedsUIClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotPresetEditScreen>.NativeClassPtr, 100672310);
			PotPresetEditScreen.NativeMethodInfoPtr_AdditivesUIClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotPresetEditScreen>.NativeClassPtr, 100672311);
			PotPresetEditScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotPresetEditScreen>.NativeClassPtr, 100672312);
		}

		// Token: 0x060048AD RID: 18605 RVA: 0x0016364C File Offset: 0x0016184C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162530, XrefRangeEnd = 162545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PotPresetEditScreen.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048AE RID: 18606 RVA: 0x00163688 File Offset: 0x00161888
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162545, XrefRangeEnd = 162546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PotPresetEditScreen.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048AF RID: 18607 RVA: 0x001636C4 File Offset: 0x001618C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162546, XrefRangeEnd = 162555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Open(Preset preset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(preset);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PotPresetEditScreen.NativeMethodInfoPtr_Open_Public_Virtual_Void_Preset_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048B0 RID: 18608 RVA: 0x00163714 File Offset: 0x00161914
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 162556, RefRangeEnd = 162558, XrefRangeStart = 162555, XrefRangeEnd = 162556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotPresetEditScreen.NativeMethodInfoPtr_UpdateUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048B1 RID: 18609 RVA: 0x00163748 File Offset: 0x00161948
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162558, XrefRangeEnd = 162565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SeedsUIClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotPresetEditScreen.NativeMethodInfoPtr_SeedsUIClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048B2 RID: 18610 RVA: 0x0016377C File Offset: 0x0016197C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162565, XrefRangeEnd = 162572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AdditivesUIClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotPresetEditScreen.NativeMethodInfoPtr_AdditivesUIClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048B3 RID: 18611 RVA: 0x001637B0 File Offset: 0x001619B0
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PotPresetEditScreen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PotPresetEditScreen>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotPresetEditScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048B4 RID: 18612 RVA: 0x00023062 File Offset: 0x00021262
		public PotPresetEditScreen(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170015D0 RID: 5584
		// (get) Token: 0x060048B5 RID: 18613 RVA: 0x001637EC File Offset: 0x001619EC
		// (set) Token: 0x060048B6 RID: 18614 RVA: 0x0002306B File Offset: 0x0002126B
		public unsafe GenericOptionUI SeedsUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotPresetEditScreen.NativeFieldInfoPtr_SeedsUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GenericOptionUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotPresetEditScreen.NativeFieldInfoPtr_SeedsUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015D1 RID: 5585
		// (get) Token: 0x060048B7 RID: 18615 RVA: 0x0016381C File Offset: 0x00161A1C
		// (set) Token: 0x060048B8 RID: 18616 RVA: 0x0002308A File Offset: 0x0002128A
		public unsafe GenericOptionUI AdditivesUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotPresetEditScreen.NativeFieldInfoPtr_AdditivesUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GenericOptionUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotPresetEditScreen.NativeFieldInfoPtr_AdditivesUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015D2 RID: 5586
		// (get) Token: 0x060048B9 RID: 18617 RVA: 0x0016384C File Offset: 0x00161A4C
		// (set) Token: 0x060048BA RID: 18618 RVA: 0x000230A9 File Offset: 0x000212A9
		public unsafe PotPreset castedPreset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotPresetEditScreen.NativeFieldInfoPtr_castedPreset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PotPreset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotPresetEditScreen.NativeFieldInfoPtr_castedPreset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003109 RID: 12553
		private static readonly IntPtr NativeFieldInfoPtr_SeedsUI;

		// Token: 0x0400310A RID: 12554
		private static readonly IntPtr NativeFieldInfoPtr_AdditivesUI;

		// Token: 0x0400310B RID: 12555
		private static readonly IntPtr NativeFieldInfoPtr_castedPreset;

		// Token: 0x0400310C RID: 12556
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x0400310D RID: 12557
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x0400310E RID: 12558
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Virtual_Void_Preset_0;

		// Token: 0x0400310F RID: 12559
		private static readonly IntPtr NativeMethodInfoPtr_UpdateUI_Private_Void_0;

		// Token: 0x04003110 RID: 12560
		private static readonly IntPtr NativeMethodInfoPtr_SeedsUIClicked_Public_Void_0;

		// Token: 0x04003111 RID: 12561
		private static readonly IntPtr NativeMethodInfoPtr_AdditivesUIClicked_Public_Void_0;

		// Token: 0x04003112 RID: 12562
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
