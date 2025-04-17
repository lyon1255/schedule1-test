using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Construction.ConstructionMethods
{
	// Token: 0x02000489 RID: 1161
	public class ConstructStart_PowerLine : ConstructStart_Base
	{
		// Token: 0x0600649F RID: 25759 RVA: 0x0002F91D File Offset: 0x0002DB1D
		// Note: this type is marked as 'beforefieldinit'.
		static ConstructStart_PowerLine()
		{
			Il2CppClassPointerStore<ConstructStart_PowerLine>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Construction.ConstructionMethods", "ConstructStart_PowerLine");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstructStart_PowerLine>.NativeClassPtr);
			ConstructStart_PowerLine.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructStart_PowerLine>.NativeClassPtr, 100676047);
		}

		// Token: 0x060064A0 RID: 25760 RVA: 0x001C7114 File Offset: 0x001C5314
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConstructStart_PowerLine() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstructStart_PowerLine>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructStart_PowerLine.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064A1 RID: 25761 RVA: 0x0002F956 File Offset: 0x0002DB56
		public ConstructStart_PowerLine(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040044A9 RID: 17577
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
