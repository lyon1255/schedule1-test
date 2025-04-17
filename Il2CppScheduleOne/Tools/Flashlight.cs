using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.Equipping;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x02000526 RID: 1318
	public class Flashlight : Equippable_Viewmodel
	{
		// Token: 0x060075DE RID: 30174 RVA: 0x00037CE0 File Offset: 0x00035EE0
		// Note: this type is marked as 'beforefieldinit'.
		static Flashlight()
		{
			Il2CppClassPointerStore<Flashlight>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "Flashlight");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Flashlight>.NativeClassPtr);
			Flashlight.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Flashlight>.NativeClassPtr, 100678153);
		}

		// Token: 0x060075DF RID: 30175 RVA: 0x00201768 File Offset: 0x001FF968
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Flashlight() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Flashlight>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Flashlight.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060075E0 RID: 30176 RVA: 0x00037D19 File Offset: 0x00035F19
		public Flashlight(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04005091 RID: 20625
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
