using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.UI.MainMenu
{
	// Token: 0x020006E6 RID: 1766
	public class JoinLocal : MonoBehaviour
	{
		// Token: 0x06009E40 RID: 40512 RVA: 0x0027FD4C File Offset: 0x0027DF4C
		// Note: this type is marked as 'beforefieldinit'.
		static JoinLocal()
		{
			Il2CppClassPointerStore<JoinLocal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.MainMenu", "JoinLocal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JoinLocal>.NativeClassPtr);
			JoinLocal.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoinLocal>.NativeClassPtr, 100682714);
			JoinLocal.NativeMethodInfoPtr_Clicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoinLocal>.NativeClassPtr, 100682715);
			JoinLocal.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoinLocal>.NativeClassPtr, 100682716);
		}

		// Token: 0x06009E41 RID: 40513 RVA: 0x0027FDB8 File Offset: 0x0027DFB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279890, XrefRangeEnd = 279902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JoinLocal.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E42 RID: 40514 RVA: 0x0027FDEC File Offset: 0x0027DFEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279902, XrefRangeEnd = 279910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JoinLocal.NativeMethodInfoPtr_Clicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E43 RID: 40515 RVA: 0x0027FE20 File Offset: 0x0027E020
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JoinLocal() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JoinLocal>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JoinLocal.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E44 RID: 40516 RVA: 0x0004D9DB File Offset: 0x0004BBDB
		public JoinLocal(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04006A3A RID: 27194
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04006A3B RID: 27195
		private static readonly IntPtr NativeMethodInfoPtr_Clicked_Public_Void_0;

		// Token: 0x04006A3C RID: 27196
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
