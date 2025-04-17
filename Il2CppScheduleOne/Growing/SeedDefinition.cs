using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;

namespace Il2CppScheduleOne.Growing
{
	// Token: 0x0200055D RID: 1373
	[Serializable]
	public class SeedDefinition : StorableItemDefinition
	{
		// Token: 0x060078B0 RID: 30896 RVA: 0x002098A0 File Offset: 0x00207AA0
		// Note: this type is marked as 'beforefieldinit'.
		static SeedDefinition()
		{
			Il2CppClassPointerStore<SeedDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Growing", "SeedDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SeedDefinition>.NativeClassPtr);
			SeedDefinition.NativeFieldInfoPtr_FunctionSeedPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SeedDefinition>.NativeClassPtr, "FunctionSeedPrefab");
			SeedDefinition.NativeFieldInfoPtr_PlantPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SeedDefinition>.NativeClassPtr, "PlantPrefab");
			SeedDefinition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SeedDefinition>.NativeClassPtr, 100678432);
		}

		// Token: 0x060078B1 RID: 30897 RVA: 0x0020990C File Offset: 0x00207B0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232517, XrefRangeEnd = 232518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SeedDefinition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SeedDefinition>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SeedDefinition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060078B2 RID: 30898 RVA: 0x00039469 File Offset: 0x00037669
		public SeedDefinition(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700247F RID: 9343
		// (get) Token: 0x060078B3 RID: 30899 RVA: 0x00209948 File Offset: 0x00207B48
		// (set) Token: 0x060078B4 RID: 30900 RVA: 0x00039472 File Offset: 0x00037672
		public unsafe FunctionalSeed FunctionSeedPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SeedDefinition.NativeFieldInfoPtr_FunctionSeedPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FunctionalSeed>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SeedDefinition.NativeFieldInfoPtr_FunctionSeedPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002480 RID: 9344
		// (get) Token: 0x060078B5 RID: 30901 RVA: 0x00209978 File Offset: 0x00207B78
		// (set) Token: 0x060078B6 RID: 30902 RVA: 0x00039491 File Offset: 0x00037691
		public unsafe Plant PlantPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SeedDefinition.NativeFieldInfoPtr_PlantPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Plant>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SeedDefinition.NativeFieldInfoPtr_PlantPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005235 RID: 21045
		private static readonly IntPtr NativeFieldInfoPtr_FunctionSeedPrefab;

		// Token: 0x04005236 RID: 21046
		private static readonly IntPtr NativeFieldInfoPtr_PlantPrefab;

		// Token: 0x04005237 RID: 21047
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
