using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Rendering.Universal;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x02000136 RID: 310
	public class URPWeatherDepth : MonoBehaviour
	{
		// Token: 0x06001A27 RID: 6695 RVA: 0x000C236C File Offset: 0x000C056C
		// Note: this type is marked as 'beforefieldinit'.
		static URPWeatherDepth()
		{
			Il2CppClassPointerStore<URPWeatherDepth>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "URPWeatherDepth");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<URPWeatherDepth>.NativeClassPtr);
			URPWeatherDepth.NativeFieldInfoPtr_renderTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<URPWeatherDepth>.NativeClassPtr, "renderTexture");
			URPWeatherDepth.NativeFieldInfoPtr_m_Camera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<URPWeatherDepth>.NativeClassPtr, "m_Camera");
			URPWeatherDepth.NativeFieldInfoPtr_m_CameraData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<URPWeatherDepth>.NativeClassPtr, "m_CameraData");
			URPWeatherDepth.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<URPWeatherDepth>.NativeClassPtr, 100666067);
			URPWeatherDepth.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<URPWeatherDepth>.NativeClassPtr, 100666068);
			URPWeatherDepth.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<URPWeatherDepth>.NativeClassPtr, 100666069);
		}

		// Token: 0x06001A28 RID: 6696 RVA: 0x000C2414 File Offset: 0x000C0614
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96930, XrefRangeEnd = 96938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(URPWeatherDepth.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A29 RID: 6697 RVA: 0x000C2448 File Offset: 0x000C0648
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96938, XrefRangeEnd = 96955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(URPWeatherDepth.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A2A RID: 6698 RVA: 0x000C247C File Offset: 0x000C067C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe URPWeatherDepth() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<URPWeatherDepth>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(URPWeatherDepth.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A2B RID: 6699 RVA: 0x0000EE0B File Offset: 0x0000D00B
		public URPWeatherDepth(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700093C RID: 2364
		// (get) Token: 0x06001A2C RID: 6700 RVA: 0x000C24B8 File Offset: 0x000C06B8
		// (set) Token: 0x06001A2D RID: 6701 RVA: 0x0000EE14 File Offset: 0x0000D014
		public unsafe RenderTexture renderTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(URPWeatherDepth.NativeFieldInfoPtr_renderTexture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(URPWeatherDepth.NativeFieldInfoPtr_renderTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700093D RID: 2365
		// (get) Token: 0x06001A2E RID: 6702 RVA: 0x000C24E8 File Offset: 0x000C06E8
		// (set) Token: 0x06001A2F RID: 6703 RVA: 0x0000EE33 File Offset: 0x0000D033
		public unsafe Camera m_Camera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(URPWeatherDepth.NativeFieldInfoPtr_m_Camera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(URPWeatherDepth.NativeFieldInfoPtr_m_Camera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700093E RID: 2366
		// (get) Token: 0x06001A30 RID: 6704 RVA: 0x000C2518 File Offset: 0x000C0718
		// (set) Token: 0x06001A31 RID: 6705 RVA: 0x0000EE52 File Offset: 0x0000D052
		public unsafe UniversalAdditionalCameraData m_CameraData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(URPWeatherDepth.NativeFieldInfoPtr_m_CameraData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UniversalAdditionalCameraData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(URPWeatherDepth.NativeFieldInfoPtr_m_CameraData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400112B RID: 4395
		private static readonly IntPtr NativeFieldInfoPtr_renderTexture;

		// Token: 0x0400112C RID: 4396
		private static readonly IntPtr NativeFieldInfoPtr_m_Camera;

		// Token: 0x0400112D RID: 4397
		private static readonly IntPtr NativeFieldInfoPtr_m_CameraData;

		// Token: 0x0400112E RID: 4398
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400112F RID: 4399
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04001130 RID: 4400
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
