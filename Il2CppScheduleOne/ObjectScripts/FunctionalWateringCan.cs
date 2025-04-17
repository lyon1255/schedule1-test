using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ObjectScripts.WateringCan;
using Il2CppScheduleOne.PlayerTasks;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x02000752 RID: 1874
	public class FunctionalWateringCan : Pourable
	{
		// Token: 0x0600B222 RID: 45602 RVA: 0x002C7328 File Offset: 0x002C5528
		// Note: this type is marked as 'beforefieldinit'.
		static FunctionalWateringCan()
		{
			Il2CppClassPointerStore<FunctionalWateringCan>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "FunctionalWateringCan");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FunctionalWateringCan>.NativeClassPtr);
			FunctionalWateringCan.NativeFieldInfoPtr_Visuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalWateringCan>.NativeClassPtr, "Visuals");
			FunctionalWateringCan.NativeFieldInfoPtr_itemInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalWateringCan>.NativeClassPtr, "itemInstance");
			FunctionalWateringCan.NativeMethodInfoPtr_Setup_Public_Void_WateringCanInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalWateringCan>.NativeClassPtr, 100685250);
			FunctionalWateringCan.NativeMethodInfoPtr_PourAmount_Protected_Virtual_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalWateringCan>.NativeClassPtr, 100685251);
			FunctionalWateringCan.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalWateringCan>.NativeClassPtr, 100685252);
		}

		// Token: 0x0600B223 RID: 45603 RVA: 0x002C73BC File Offset: 0x002C55BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 307006, RefRangeEnd = 307007, XrefRangeStart = 307003, XrefRangeEnd = 307006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Setup(WateringCanInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionalWateringCan.NativeMethodInfoPtr_Setup_Public_Void_WateringCanInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B224 RID: 45604 RVA: 0x002C7400 File Offset: 0x002C5600
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307007, XrefRangeEnd = 307010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PourAmount(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalWateringCan.NativeMethodInfoPtr_PourAmount_Protected_Virtual_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B225 RID: 45605 RVA: 0x002C744C File Offset: 0x002C564C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FunctionalWateringCan() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FunctionalWateringCan>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionalWateringCan.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B226 RID: 45606 RVA: 0x00057600 File Offset: 0x00055800
		public FunctionalWateringCan(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003747 RID: 14151
		// (get) Token: 0x0600B227 RID: 45607 RVA: 0x002C7488 File Offset: 0x002C5688
		// (set) Token: 0x0600B228 RID: 45608 RVA: 0x00057609 File Offset: 0x00055809
		public unsafe WateringCanVisuals Visuals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalWateringCan.NativeFieldInfoPtr_Visuals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WateringCanVisuals>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalWateringCan.NativeFieldInfoPtr_Visuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003748 RID: 14152
		// (get) Token: 0x0600B229 RID: 45609 RVA: 0x002C74B8 File Offset: 0x002C56B8
		// (set) Token: 0x0600B22A RID: 45610 RVA: 0x00057628 File Offset: 0x00055828
		public unsafe WateringCanInstance itemInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalWateringCan.NativeFieldInfoPtr_itemInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WateringCanInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalWateringCan.NativeFieldInfoPtr_itemInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007823 RID: 30755
		private static readonly IntPtr NativeFieldInfoPtr_Visuals;

		// Token: 0x04007824 RID: 30756
		private static readonly IntPtr NativeFieldInfoPtr_itemInstance;

		// Token: 0x04007825 RID: 30757
		private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Void_WateringCanInstance_0;

		// Token: 0x04007826 RID: 30758
		private static readonly IntPtr NativeMethodInfoPtr_PourAmount_Protected_Virtual_Void_Single_0;

		// Token: 0x04007827 RID: 30759
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
