using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000035 RID: 53
	public class LookAtCamera : MonoBehaviour
	{
		// Token: 0x060003AA RID: 938 RVA: 0x0007BA44 File Offset: 0x00079C44
		// Note: this type is marked as 'beforefieldinit'.
		static LookAtCamera()
		{
			Il2CppClassPointerStore<LookAtCamera>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "LookAtCamera");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LookAtCamera>.NativeClassPtr);
			LookAtCamera.NativeFieldInfoPtr_lookAtCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LookAtCamera>.NativeClassPtr, "lookAtCamera");
			LookAtCamera.NativeFieldInfoPtr_lookOnlyOnAwake = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LookAtCamera>.NativeClassPtr, "lookOnlyOnAwake");
			LookAtCamera.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookAtCamera>.NativeClassPtr, 100663645);
			LookAtCamera.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookAtCamera>.NativeClassPtr, 100663646);
			LookAtCamera.NativeMethodInfoPtr_LookCam_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookAtCamera>.NativeClassPtr, 100663647);
			LookAtCamera.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookAtCamera>.NativeClassPtr, 100663648);
		}

		// Token: 0x060003AB RID: 939 RVA: 0x0007BAEC File Offset: 0x00079CEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73723, XrefRangeEnd = 73732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LookAtCamera.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003AC RID: 940 RVA: 0x0007BB20 File Offset: 0x00079D20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73732, XrefRangeEnd = 73735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LookAtCamera.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003AD RID: 941 RVA: 0x0007BB54 File Offset: 0x00079D54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73735, XrefRangeEnd = 73739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LookCam()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LookAtCamera.NativeMethodInfoPtr_LookCam_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003AE RID: 942 RVA: 0x0007BB88 File Offset: 0x00079D88
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LookAtCamera() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LookAtCamera>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LookAtCamera.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003AF RID: 943 RVA: 0x00004144 File Offset: 0x00002344
		public LookAtCamera(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x060003B0 RID: 944 RVA: 0x0007BBC4 File Offset: 0x00079DC4
		// (set) Token: 0x060003B1 RID: 945 RVA: 0x0000414D File Offset: 0x0000234D
		public unsafe Camera lookAtCamera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookAtCamera.NativeFieldInfoPtr_lookAtCamera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookAtCamera.NativeFieldInfoPtr_lookAtCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x060003B2 RID: 946 RVA: 0x0007BBF4 File Offset: 0x00079DF4
		// (set) Token: 0x060003B3 RID: 947 RVA: 0x0000416C File Offset: 0x0000236C
		public unsafe bool lookOnlyOnAwake
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookAtCamera.NativeFieldInfoPtr_lookOnlyOnAwake);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookAtCamera.NativeFieldInfoPtr_lookOnlyOnAwake)) = value;
			}
		}

		// Token: 0x04000233 RID: 563
		private static readonly IntPtr NativeFieldInfoPtr_lookAtCamera;

		// Token: 0x04000234 RID: 564
		private static readonly IntPtr NativeFieldInfoPtr_lookOnlyOnAwake;

		// Token: 0x04000235 RID: 565
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x04000236 RID: 566
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x04000237 RID: 567
		private static readonly IntPtr NativeMethodInfoPtr_LookCam_Public_Void_0;

		// Token: 0x04000238 RID: 568
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
