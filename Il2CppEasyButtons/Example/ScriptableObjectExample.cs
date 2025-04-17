using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppEasyButtons.Example
{
	// Token: 0x02000139 RID: 313
	public class ScriptableObjectExample : ScriptableObject
	{
		// Token: 0x06001A43 RID: 6723 RVA: 0x000C2980 File Offset: 0x000C0B80
		// Note: this type is marked as 'beforefieldinit'.
		static ScriptableObjectExample()
		{
			Il2CppClassPointerStore<ScriptableObjectExample>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "EasyButtons.Example", "ScriptableObjectExample");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptableObjectExample>.NativeClassPtr);
			ScriptableObjectExample.NativeMethodInfoPtr_SayHello_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableObjectExample>.NativeClassPtr, 100666083);
			ScriptableObjectExample.NativeMethodInfoPtr_SayHelloEditor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableObjectExample>.NativeClassPtr, 100666084);
			ScriptableObjectExample.NativeMethodInfoPtr_SayHelloPlayMode_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableObjectExample>.NativeClassPtr, 100666085);
			ScriptableObjectExample.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableObjectExample>.NativeClassPtr, 100666086);
		}

		// Token: 0x06001A44 RID: 6724 RVA: 0x000C2A00 File Offset: 0x000C0C00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97022, XrefRangeEnd = 97037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SayHello()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableObjectExample.NativeMethodInfoPtr_SayHello_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A45 RID: 6725 RVA: 0x000C2A34 File Offset: 0x000C0C34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97037, XrefRangeEnd = 97043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SayHelloEditor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableObjectExample.NativeMethodInfoPtr_SayHelloEditor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A46 RID: 6726 RVA: 0x000C2A68 File Offset: 0x000C0C68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97043, XrefRangeEnd = 97049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SayHelloPlayMode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableObjectExample.NativeMethodInfoPtr_SayHelloPlayMode_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A47 RID: 6727 RVA: 0x000C2A9C File Offset: 0x000C0C9C
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 88913, RefRangeEnd = 88925, XrefRangeStart = 88913, XrefRangeEnd = 88925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScriptableObjectExample() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptableObjectExample>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableObjectExample.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A48 RID: 6728 RVA: 0x0000EE83 File Offset: 0x0000D083
		public ScriptableObjectExample(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400113E RID: 4414
		private static readonly IntPtr NativeMethodInfoPtr_SayHello_Public_Void_0;

		// Token: 0x0400113F RID: 4415
		private static readonly IntPtr NativeMethodInfoPtr_SayHelloEditor_Public_Void_0;

		// Token: 0x04001140 RID: 4416
		private static readonly IntPtr NativeMethodInfoPtr_SayHelloPlayMode_Public_Void_0;

		// Token: 0x04001141 RID: 4417
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
