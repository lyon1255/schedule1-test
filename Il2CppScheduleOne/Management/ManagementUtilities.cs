using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x0200039F RID: 927
	public class ManagementUtilities : Singleton<ManagementUtilities>
	{
		// Token: 0x060048A1 RID: 18593 RVA: 0x00163378 File Offset: 0x00161578
		// Note: this type is marked as 'beforefieldinit'.
		static ManagementUtilities()
		{
			Il2CppClassPointerStore<ManagementUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "ManagementUtilities");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManagementUtilities>.NativeClassPtr);
			ManagementUtilities.NativeFieldInfoPtr_weedSeedAssetPaths = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementUtilities>.NativeClassPtr, "weedSeedAssetPaths");
			ManagementUtilities.NativeFieldInfoPtr_additiveAssetPaths = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementUtilities>.NativeClassPtr, "additiveAssetPaths");
			ManagementUtilities.NativeFieldInfoPtr_AdditiveDefinitions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementUtilities>.NativeClassPtr, "AdditiveDefinitions");
			ManagementUtilities.NativeMethodInfoPtr_get_WeedSeedAssetPaths_Public_Static_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementUtilities>.NativeClassPtr, 100672303);
			ManagementUtilities.NativeMethodInfoPtr_get_AdditiveAssetPaths_Public_Static_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementUtilities>.NativeClassPtr, 100672304);
			ManagementUtilities.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementUtilities>.NativeClassPtr, 100672305);
		}

		// Token: 0x170015CE RID: 5582
		// (get) Token: 0x060048A2 RID: 18594 RVA: 0x00163420 File Offset: 0x00161620
		public unsafe static List<string> WeedSeedAssetPaths
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162500, XrefRangeEnd = 162504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementUtilities.NativeMethodInfoPtr_get_WeedSeedAssetPaths_Public_Static_get_List_1_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
		}

		// Token: 0x170015CF RID: 5583
		// (get) Token: 0x060048A3 RID: 18595 RVA: 0x00163454 File Offset: 0x00161654
		public unsafe static List<string> AdditiveAssetPaths
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162504, XrefRangeEnd = 162508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementUtilities.NativeMethodInfoPtr_get_AdditiveAssetPaths_Public_Static_get_List_1_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
		}

		// Token: 0x060048A4 RID: 18596 RVA: 0x00163488 File Offset: 0x00161688
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162508, XrefRangeEnd = 162530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ManagementUtilities() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManagementUtilities>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementUtilities.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048A5 RID: 18597 RVA: 0x00022FFC File Offset: 0x000211FC
		public ManagementUtilities(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170015CB RID: 5579
		// (get) Token: 0x060048A6 RID: 18598 RVA: 0x001634C4 File Offset: 0x001616C4
		// (set) Token: 0x060048A7 RID: 18599 RVA: 0x00023005 File Offset: 0x00021205
		public unsafe List<string> weedSeedAssetPaths
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementUtilities.NativeFieldInfoPtr_weedSeedAssetPaths);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementUtilities.NativeFieldInfoPtr_weedSeedAssetPaths), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015CC RID: 5580
		// (get) Token: 0x060048A8 RID: 18600 RVA: 0x001634F4 File Offset: 0x001616F4
		// (set) Token: 0x060048A9 RID: 18601 RVA: 0x00023024 File Offset: 0x00021224
		public unsafe List<string> additiveAssetPaths
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementUtilities.NativeFieldInfoPtr_additiveAssetPaths);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementUtilities.NativeFieldInfoPtr_additiveAssetPaths), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015CD RID: 5581
		// (get) Token: 0x060048AA RID: 18602 RVA: 0x00163524 File Offset: 0x00161724
		// (set) Token: 0x060048AB RID: 18603 RVA: 0x00023043 File Offset: 0x00021243
		public unsafe List<AdditiveDefinition> AdditiveDefinitions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementUtilities.NativeFieldInfoPtr_AdditiveDefinitions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AdditiveDefinition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementUtilities.NativeFieldInfoPtr_AdditiveDefinitions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003103 RID: 12547
		private static readonly IntPtr NativeFieldInfoPtr_weedSeedAssetPaths;

		// Token: 0x04003104 RID: 12548
		private static readonly IntPtr NativeFieldInfoPtr_additiveAssetPaths;

		// Token: 0x04003105 RID: 12549
		private static readonly IntPtr NativeFieldInfoPtr_AdditiveDefinitions;

		// Token: 0x04003106 RID: 12550
		private static readonly IntPtr NativeMethodInfoPtr_get_WeedSeedAssetPaths_Public_Static_get_List_1_String_0;

		// Token: 0x04003107 RID: 12551
		private static readonly IntPtr NativeMethodInfoPtr_get_AdditiveAssetPaths_Public_Static_get_List_1_String_0;

		// Token: 0x04003108 RID: 12552
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
