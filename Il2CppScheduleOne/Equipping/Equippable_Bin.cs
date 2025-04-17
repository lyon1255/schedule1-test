using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ObjectScripts.HandheldBin;

namespace Il2CppScheduleOne.Equipping
{
	// Token: 0x020005B9 RID: 1465
	public class Equippable_Bin : Equippable_Viewmodel
	{
		// Token: 0x0600808B RID: 32907 RVA: 0x00225A04 File Offset: 0x00223C04
		// Note: this type is marked as 'beforefieldinit'.
		static Equippable_Bin()
		{
			Il2CppClassPointerStore<Equippable_Bin>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Equipping", "Equippable_Bin");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable_Bin>.NativeClassPtr);
			Equippable_Bin.NativeFieldInfoPtr_bin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Bin>.NativeClassPtr, "bin");
			Equippable_Bin.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Bin>.NativeClassPtr, 100679428);
		}

		// Token: 0x0600808C RID: 32908 RVA: 0x00225A5C File Offset: 0x00223C5C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 244274, RefRangeEnd = 244282, XrefRangeStart = 244274, XrefRangeEnd = 244282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Equippable_Bin() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable_Bin>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_Bin.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600808D RID: 32909 RVA: 0x0003CFC0 File Offset: 0x0003B1C0
		public Equippable_Bin(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170026D4 RID: 9940
		// (get) Token: 0x0600808E RID: 32910 RVA: 0x00225A98 File Offset: 0x00223C98
		// (set) Token: 0x0600808F RID: 32911 RVA: 0x0003CFC9 File Offset: 0x0003B1C9
		public unsafe HandheldBin_Functional bin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Bin.NativeFieldInfoPtr_bin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HandheldBin_Functional>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Bin.NativeFieldInfoPtr_bin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400578D RID: 22413
		private static readonly IntPtr NativeFieldInfoPtr_bin;

		// Token: 0x0400578E RID: 22414
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
