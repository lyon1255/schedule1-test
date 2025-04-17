using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x0200011E RID: 286
	public class LoadOverheadDepthTexture : MonoBehaviour
	{
		// Token: 0x06001869 RID: 6249 RVA: 0x000BC834 File Offset: 0x000BAA34
		// Note: this type is marked as 'beforefieldinit'.
		static LoadOverheadDepthTexture()
		{
			Il2CppClassPointerStore<LoadOverheadDepthTexture>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "LoadOverheadDepthTexture");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadOverheadDepthTexture>.NativeClassPtr);
			LoadOverheadDepthTexture.NativeFieldInfoPtr_m_RainCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadOverheadDepthTexture>.NativeClassPtr, "m_RainCamera");
			LoadOverheadDepthTexture.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadOverheadDepthTexture>.NativeClassPtr, 100665896);
			LoadOverheadDepthTexture.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadOverheadDepthTexture>.NativeClassPtr, 100665897);
			LoadOverheadDepthTexture.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadOverheadDepthTexture>.NativeClassPtr, 100665898);
		}

		// Token: 0x0600186A RID: 6250 RVA: 0x000BC8B4 File Offset: 0x000BAAB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95286, XrefRangeEnd = 95293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadOverheadDepthTexture.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600186B RID: 6251 RVA: 0x000BC8E8 File Offset: 0x000BAAE8
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadOverheadDepthTexture.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600186C RID: 6252 RVA: 0x000BC91C File Offset: 0x000BAB1C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LoadOverheadDepthTexture() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadOverheadDepthTexture>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadOverheadDepthTexture.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600186D RID: 6253 RVA: 0x0000E08C File Offset: 0x0000C28C
		public LoadOverheadDepthTexture(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170008BC RID: 2236
		// (get) Token: 0x0600186E RID: 6254 RVA: 0x000BC958 File Offset: 0x000BAB58
		// (set) Token: 0x0600186F RID: 6255 RVA: 0x0000E095 File Offset: 0x0000C295
		public unsafe WeatherDepthCamera m_RainCamera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadOverheadDepthTexture.NativeFieldInfoPtr_m_RainCamera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WeatherDepthCamera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadOverheadDepthTexture.NativeFieldInfoPtr_m_RainCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001009 RID: 4105
		private static readonly IntPtr NativeFieldInfoPtr_m_RainCamera;

		// Token: 0x0400100A RID: 4106
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400100B RID: 4107
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400100C RID: 4108
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
