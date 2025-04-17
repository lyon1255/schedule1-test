using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x02000538 RID: 1336
	public class ExitToMenu : MonoBehaviour
	{
		// Token: 0x060076C6 RID: 30406 RVA: 0x002040F4 File Offset: 0x002022F4
		// Note: this type is marked as 'beforefieldinit'.
		static ExitToMenu()
		{
			Il2CppClassPointerStore<ExitToMenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "ExitToMenu");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExitToMenu>.NativeClassPtr);
			ExitToMenu.NativeMethodInfoPtr_Exit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExitToMenu>.NativeClassPtr, 100678254);
			ExitToMenu.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExitToMenu>.NativeClassPtr, 100678255);
		}

		// Token: 0x060076C7 RID: 30407 RVA: 0x0020414C File Offset: 0x0020234C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230964, XrefRangeEnd = 230969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExitToMenu.NativeMethodInfoPtr_Exit_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060076C8 RID: 30408 RVA: 0x00204180 File Offset: 0x00202380
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExitToMenu() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExitToMenu>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExitToMenu.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060076C9 RID: 30409 RVA: 0x0003846D File Offset: 0x0003666D
		public ExitToMenu(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04005119 RID: 20761
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Public_Void_0;

		// Token: 0x0400511A RID: 20762
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
