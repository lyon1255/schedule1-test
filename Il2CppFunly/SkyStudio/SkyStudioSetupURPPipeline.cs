using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Rendering;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x02000135 RID: 309
	public class SkyStudioSetupURPPipeline : MonoBehaviour
	{
		// Token: 0x06001A21 RID: 6689 RVA: 0x000C2260 File Offset: 0x000C0460
		// Note: this type is marked as 'beforefieldinit'.
		static SkyStudioSetupURPPipeline()
		{
			Il2CppClassPointerStore<SkyStudioSetupURPPipeline>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "SkyStudioSetupURPPipeline");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkyStudioSetupURPPipeline>.NativeClassPtr);
			SkyStudioSetupURPPipeline.NativeFieldInfoPtr_pipelineAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyStudioSetupURPPipeline>.NativeClassPtr, "pipelineAsset");
			SkyStudioSetupURPPipeline.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyStudioSetupURPPipeline>.NativeClassPtr, 100666065);
			SkyStudioSetupURPPipeline.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyStudioSetupURPPipeline>.NativeClassPtr, 100666066);
		}

		// Token: 0x06001A22 RID: 6690 RVA: 0x000C22CC File Offset: 0x000C04CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96923, XrefRangeEnd = 96930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkyStudioSetupURPPipeline.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A23 RID: 6691 RVA: 0x000C2300 File Offset: 0x000C0500
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SkyStudioSetupURPPipeline() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkyStudioSetupURPPipeline>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkyStudioSetupURPPipeline.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A24 RID: 6692 RVA: 0x0000EDE3 File Offset: 0x0000CFE3
		public SkyStudioSetupURPPipeline(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700093B RID: 2363
		// (get) Token: 0x06001A25 RID: 6693 RVA: 0x000C233C File Offset: 0x000C053C
		// (set) Token: 0x06001A26 RID: 6694 RVA: 0x0000EDEC File Offset: 0x0000CFEC
		public unsafe RenderPipelineAsset pipelineAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkyStudioSetupURPPipeline.NativeFieldInfoPtr_pipelineAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderPipelineAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkyStudioSetupURPPipeline.NativeFieldInfoPtr_pipelineAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001128 RID: 4392
		private static readonly IntPtr NativeFieldInfoPtr_pipelineAsset;

		// Token: 0x04001129 RID: 4393
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400112A RID: 4394
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
