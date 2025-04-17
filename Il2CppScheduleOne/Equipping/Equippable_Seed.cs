using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Growing;
using Il2CppScheduleOne.ObjectScripts;

namespace Il2CppScheduleOne.Equipping
{
	// Token: 0x020005B8 RID: 1464
	public class Equippable_Seed : Equippable_Viewmodel
	{
		// Token: 0x06008084 RID: 32900 RVA: 0x0022588C File Offset: 0x00223A8C
		// Note: this type is marked as 'beforefieldinit'.
		static Equippable_Seed()
		{
			Il2CppClassPointerStore<Equippable_Seed>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Equipping", "Equippable_Seed");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable_Seed>.NativeClassPtr);
			Equippable_Seed.NativeFieldInfoPtr_Seed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Seed>.NativeClassPtr, "Seed");
			Equippable_Seed.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Seed>.NativeClassPtr, 100679425);
			Equippable_Seed.NativeMethodInfoPtr_StartSowSeedTask_Protected_Virtual_New_Void_Pot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Seed>.NativeClassPtr, 100679426);
			Equippable_Seed.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Seed>.NativeClassPtr, 100679427);
		}

		// Token: 0x06008085 RID: 32901 RVA: 0x0022590C File Offset: 0x00223B0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244282, XrefRangeEnd = 244328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Seed.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008086 RID: 32902 RVA: 0x00225948 File Offset: 0x00223B48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244328, XrefRangeEnd = 244332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void StartSowSeedTask(Pot pot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pot);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Seed.NativeMethodInfoPtr_StartSowSeedTask_Protected_Virtual_New_Void_Pot_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008087 RID: 32903 RVA: 0x00225998 File Offset: 0x00223B98
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 244274, RefRangeEnd = 244282, XrefRangeStart = 244274, XrefRangeEnd = 244282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Equippable_Seed() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable_Seed>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_Seed.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008088 RID: 32904 RVA: 0x0003CF98 File Offset: 0x0003B198
		public Equippable_Seed(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170026D3 RID: 9939
		// (get) Token: 0x06008089 RID: 32905 RVA: 0x002259D4 File Offset: 0x00223BD4
		// (set) Token: 0x0600808A RID: 32906 RVA: 0x0003CFA1 File Offset: 0x0003B1A1
		public unsafe SeedDefinition Seed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Seed.NativeFieldInfoPtr_Seed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SeedDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Seed.NativeFieldInfoPtr_Seed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005789 RID: 22409
		private static readonly IntPtr NativeFieldInfoPtr_Seed;

		// Token: 0x0400578A RID: 22410
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x0400578B RID: 22411
		private static readonly IntPtr NativeMethodInfoPtr_StartSowSeedTask_Protected_Virtual_New_Void_Pot_0;

		// Token: 0x0400578C RID: 22412
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
