using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200001B RID: 27
	public class TestSetup : MonoBehaviour
	{
		// Token: 0x060001A9 RID: 425 RVA: 0x00075CD0 File Offset: 0x00073ED0
		// Note: this type is marked as 'beforefieldinit'.
		static TestSetup()
		{
			Il2CppClassPointerStore<TestSetup>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "TestSetup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TestSetup>.NativeClassPtr);
			TestSetup.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestSetup>.NativeClassPtr, 100663451);
			TestSetup.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestSetup>.NativeClassPtr, 100663452);
			TestSetup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestSetup>.NativeClassPtr, 100663453);
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00075D3C File Offset: 0x00073F3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72171, XrefRangeEnd = 72177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TestSetup.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00075D70 File Offset: 0x00073F70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72177, XrefRangeEnd = 72197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TestSetup.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00075DA4 File Offset: 0x00073FA4
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TestSetup() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TestSetup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TestSetup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00002E88 File Offset: 0x00001088
		public TestSetup(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040000FD RID: 253
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040000FE RID: 254
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040000FF RID: 255
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
