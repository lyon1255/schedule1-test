using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppVLB
{
	// Token: 0x0200009B RID: 155
	public class VolumetricCookieHD : MonoBehaviour
	{
		// Token: 0x060009E1 RID: 2529 RVA: 0x0008EF3C File Offset: 0x0008D13C
		// Note: this type is marked as 'beforefieldinit'.
		static VolumetricCookieHD()
		{
			Il2CppClassPointerStore<VolumetricCookieHD>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "VolumetricCookieHD");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumetricCookieHD>.NativeClassPtr);
			VolumetricCookieHD.NativeFieldInfoPtr_ClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricCookieHD>.NativeClassPtr, "ClassName");
			VolumetricCookieHD.NativeFieldInfoPtr_m_Contribution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricCookieHD>.NativeClassPtr, "m_Contribution");
			VolumetricCookieHD.NativeFieldInfoPtr_m_CookieTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricCookieHD>.NativeClassPtr, "m_CookieTexture");
			VolumetricCookieHD.NativeFieldInfoPtr_m_Channel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricCookieHD>.NativeClassPtr, "m_Channel");
			VolumetricCookieHD.NativeFieldInfoPtr_m_Negative = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricCookieHD>.NativeClassPtr, "m_Negative");
			VolumetricCookieHD.NativeFieldInfoPtr_m_Translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricCookieHD>.NativeClassPtr, "m_Translation");
			VolumetricCookieHD.NativeFieldInfoPtr_m_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricCookieHD>.NativeClassPtr, "m_Rotation");
			VolumetricCookieHD.NativeFieldInfoPtr_m_Scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricCookieHD>.NativeClassPtr, "m_Scale");
			VolumetricCookieHD.NativeFieldInfoPtr_m_Master = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricCookieHD>.NativeClassPtr, "m_Master");
			VolumetricCookieHD.NativeMethodInfoPtr_get_contribution_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricCookieHD>.NativeClassPtr, 100664379);
			VolumetricCookieHD.NativeMethodInfoPtr_set_contribution_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricCookieHD>.NativeClassPtr, 100664380);
			VolumetricCookieHD.NativeMethodInfoPtr_get_cookieTexture_Public_get_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricCookieHD>.NativeClassPtr, 100664381);
			VolumetricCookieHD.NativeMethodInfoPtr_set_cookieTexture_Public_set_Void_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricCookieHD>.NativeClassPtr, 100664382);
			VolumetricCookieHD.NativeMethodInfoPtr_get_channel_Public_get_CookieChannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricCookieHD>.NativeClassPtr, 100664383);
			VolumetricCookieHD.NativeMethodInfoPtr_set_channel_Public_set_Void_CookieChannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricCookieHD>.NativeClassPtr, 100664384);
			VolumetricCookieHD.NativeMethodInfoPtr_get_negative_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricCookieHD>.NativeClassPtr, 100664385);
			VolumetricCookieHD.NativeMethodInfoPtr_set_negative_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricCookieHD>.NativeClassPtr, 100664386);
			VolumetricCookieHD.NativeMethodInfoPtr_get_translation_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricCookieHD>.NativeClassPtr, 100664387);
			VolumetricCookieHD.NativeMethodInfoPtr_set_translation_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricCookieHD>.NativeClassPtr, 100664388);
			VolumetricCookieHD.NativeMethodInfoPtr_get_rotation_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricCookieHD>.NativeClassPtr, 100664389);
			VolumetricCookieHD.NativeMethodInfoPtr_set_rotation_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricCookieHD>.NativeClassPtr, 100664390);
			VolumetricCookieHD.NativeMethodInfoPtr_get_scale_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricCookieHD>.NativeClassPtr, 100664391);
			VolumetricCookieHD.NativeMethodInfoPtr_set_scale_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricCookieHD>.NativeClassPtr, 100664392);
			VolumetricCookieHD.NativeMethodInfoPtr_SetDirty_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricCookieHD>.NativeClassPtr, 100664393);
			VolumetricCookieHD.NativeMethodInfoPtr_ApplyMaterialProperties_Public_Static_Void_VolumetricCookieHD_BeamGeometryHD_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricCookieHD>.NativeClassPtr, 100664394);
			VolumetricCookieHD.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricCookieHD>.NativeClassPtr, 100664395);
			VolumetricCookieHD.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricCookieHD>.NativeClassPtr, 100664396);
			VolumetricCookieHD.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricCookieHD>.NativeClassPtr, 100664397);
			VolumetricCookieHD.NativeMethodInfoPtr_OnDidApplyAnimationProperties_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricCookieHD>.NativeClassPtr, 100664398);
			VolumetricCookieHD.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricCookieHD>.NativeClassPtr, 100664399);
			VolumetricCookieHD.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricCookieHD>.NativeClassPtr, 100664400);
			VolumetricCookieHD.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricCookieHD>.NativeClassPtr, 100664401);
		}

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x060009E2 RID: 2530 RVA: 0x0008F1EC File Offset: 0x0008D3EC
		// (set) Token: 0x060009E3 RID: 2531 RVA: 0x0008F228 File Offset: 0x0008D428
		public unsafe float contribution
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricCookieHD.NativeMethodInfoPtr_get_contribution_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80852, XrefRangeEnd = 80853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricCookieHD.NativeMethodInfoPtr_set_contribution_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x060009E4 RID: 2532 RVA: 0x0008F268 File Offset: 0x0008D468
		// (set) Token: 0x060009E5 RID: 2533 RVA: 0x0008F2A8 File Offset: 0x0008D4A8
		public unsafe Texture cookieTexture
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19639, RefRangeEnd = 19642, XrefRangeStart = 19639, XrefRangeEnd = 19642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricCookieHD.NativeMethodInfoPtr_get_cookieTexture_Public_get_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80853, XrefRangeEnd = 80859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricCookieHD.NativeMethodInfoPtr_set_cookieTexture_Public_set_Void_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x060009E6 RID: 2534 RVA: 0x0008F2EC File Offset: 0x0008D4EC
		// (set) Token: 0x060009E7 RID: 2535 RVA: 0x0008F328 File Offset: 0x0008D528
		public unsafe CookieChannel channel
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 40386, RefRangeEnd = 40387, XrefRangeStart = 40386, XrefRangeEnd = 40387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricCookieHD.NativeMethodInfoPtr_get_channel_Public_get_CookieChannel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80859, XrefRangeEnd = 80860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricCookieHD.NativeMethodInfoPtr_set_channel_Public_set_Void_CookieChannel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x060009E8 RID: 2536 RVA: 0x0008F368 File Offset: 0x0008D568
		// (set) Token: 0x060009E9 RID: 2537 RVA: 0x0008F3A4 File Offset: 0x0008D5A4
		public unsafe bool negative
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricCookieHD.NativeMethodInfoPtr_get_negative_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80860, XrefRangeEnd = 80861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricCookieHD.NativeMethodInfoPtr_set_negative_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x060009EA RID: 2538 RVA: 0x0008F3E4 File Offset: 0x0008D5E4
		// (set) Token: 0x060009EB RID: 2539 RVA: 0x0008F420 File Offset: 0x0008D620
		public unsafe Vector2 translation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricCookieHD.NativeMethodInfoPtr_get_translation_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80861, XrefRangeEnd = 80862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricCookieHD.NativeMethodInfoPtr_set_translation_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x060009EC RID: 2540 RVA: 0x0008F460 File Offset: 0x0008D660
		// (set) Token: 0x060009ED RID: 2541 RVA: 0x0008F49C File Offset: 0x0008D69C
		public unsafe float rotation
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30023, RefRangeEnd = 30024, XrefRangeStart = 30023, XrefRangeEnd = 30024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricCookieHD.NativeMethodInfoPtr_get_rotation_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80862, XrefRangeEnd = 80863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricCookieHD.NativeMethodInfoPtr_set_rotation_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x060009EE RID: 2542 RVA: 0x0008F4DC File Offset: 0x0008D6DC
		// (set) Token: 0x060009EF RID: 2543 RVA: 0x0008F518 File Offset: 0x0008D718
		public unsafe Vector2 scale
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricCookieHD.NativeMethodInfoPtr_get_scale_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80863, XrefRangeEnd = 80864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricCookieHD.NativeMethodInfoPtr_set_scale_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009F0 RID: 2544 RVA: 0x0008F558 File Offset: 0x0008D758
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 80869, RefRangeEnd = 80881, XrefRangeStart = 80864, XrefRangeEnd = 80869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDirty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricCookieHD.NativeMethodInfoPtr_SetDirty_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009F1 RID: 2545 RVA: 0x0008F58C File Offset: 0x0008D78C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 80902, RefRangeEnd = 80903, XrefRangeStart = 80881, XrefRangeEnd = 80902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ApplyMaterialProperties(VolumetricCookieHD instance, BeamGeometryHD geom)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(geom);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricCookieHD.NativeMethodInfoPtr_ApplyMaterialProperties_Public_Static_Void_VolumetricCookieHD_BeamGeometryHD_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009F2 RID: 2546 RVA: 0x0008F5D4 File Offset: 0x0008D7D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80903, XrefRangeEnd = 80907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricCookieHD.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009F3 RID: 2547 RVA: 0x0008F608 File Offset: 0x0008D808
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80907, XrefRangeEnd = 80908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricCookieHD.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009F4 RID: 2548 RVA: 0x0008F63C File Offset: 0x0008D83C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricCookieHD.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009F5 RID: 2549 RVA: 0x0008F670 File Offset: 0x0008D870
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDidApplyAnimationProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricCookieHD.NativeMethodInfoPtr_OnDidApplyAnimationProperties_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009F6 RID: 2550 RVA: 0x0008F6A4 File Offset: 0x0008D8A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80908, XrefRangeEnd = 80913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricCookieHD.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009F7 RID: 2551 RVA: 0x0008F6D8 File Offset: 0x0008D8D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80913, XrefRangeEnd = 80918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricCookieHD.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009F8 RID: 2552 RVA: 0x0008F70C File Offset: 0x0008D90C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80918, XrefRangeEnd = 80924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VolumetricCookieHD() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumetricCookieHD>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricCookieHD.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009F9 RID: 2553 RVA: 0x0000744D File Offset: 0x0000564D
		public VolumetricCookieHD(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x060009FA RID: 2554 RVA: 0x0008F748 File Offset: 0x0008D948
		// (set) Token: 0x060009FB RID: 2555 RVA: 0x00007456 File Offset: 0x00005656
		public unsafe static string ClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(VolumetricCookieHD.NativeFieldInfoPtr_ClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VolumetricCookieHD.NativeFieldInfoPtr_ClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x060009FC RID: 2556 RVA: 0x0008F768 File Offset: 0x0008D968
		// (set) Token: 0x060009FD RID: 2557 RVA: 0x00007468 File Offset: 0x00005668
		public unsafe float m_Contribution
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricCookieHD.NativeFieldInfoPtr_m_Contribution);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricCookieHD.NativeFieldInfoPtr_m_Contribution)) = value;
			}
		}

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x060009FE RID: 2558 RVA: 0x0008F790 File Offset: 0x0008D990
		// (set) Token: 0x060009FF RID: 2559 RVA: 0x00007483 File Offset: 0x00005683
		public unsafe Texture m_CookieTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricCookieHD.NativeFieldInfoPtr_m_CookieTexture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricCookieHD.NativeFieldInfoPtr_m_CookieTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x06000A00 RID: 2560 RVA: 0x0008F7C0 File Offset: 0x0008D9C0
		// (set) Token: 0x06000A01 RID: 2561 RVA: 0x000074A2 File Offset: 0x000056A2
		public unsafe CookieChannel m_Channel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricCookieHD.NativeFieldInfoPtr_m_Channel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricCookieHD.NativeFieldInfoPtr_m_Channel)) = value;
			}
		}

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x06000A02 RID: 2562 RVA: 0x0008F7E8 File Offset: 0x0008D9E8
		// (set) Token: 0x06000A03 RID: 2563 RVA: 0x000074BD File Offset: 0x000056BD
		public unsafe bool m_Negative
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricCookieHD.NativeFieldInfoPtr_m_Negative);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricCookieHD.NativeFieldInfoPtr_m_Negative)) = value;
			}
		}

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x06000A04 RID: 2564 RVA: 0x0008F810 File Offset: 0x0008DA10
		// (set) Token: 0x06000A05 RID: 2565 RVA: 0x000074D8 File Offset: 0x000056D8
		public unsafe Vector2 m_Translation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricCookieHD.NativeFieldInfoPtr_m_Translation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricCookieHD.NativeFieldInfoPtr_m_Translation)) = value;
			}
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x06000A06 RID: 2566 RVA: 0x0008F838 File Offset: 0x0008DA38
		// (set) Token: 0x06000A07 RID: 2567 RVA: 0x000074F3 File Offset: 0x000056F3
		public unsafe float m_Rotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricCookieHD.NativeFieldInfoPtr_m_Rotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricCookieHD.NativeFieldInfoPtr_m_Rotation)) = value;
			}
		}

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06000A08 RID: 2568 RVA: 0x0008F860 File Offset: 0x0008DA60
		// (set) Token: 0x06000A09 RID: 2569 RVA: 0x0000750E File Offset: 0x0000570E
		public unsafe Vector2 m_Scale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricCookieHD.NativeFieldInfoPtr_m_Scale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricCookieHD.NativeFieldInfoPtr_m_Scale)) = value;
			}
		}

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x06000A0A RID: 2570 RVA: 0x0008F888 File Offset: 0x0008DA88
		// (set) Token: 0x06000A0B RID: 2571 RVA: 0x00007529 File Offset: 0x00005729
		public unsafe VolumetricLightBeamHD m_Master
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricCookieHD.NativeFieldInfoPtr_m_Master);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumetricLightBeamHD>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricCookieHD.NativeFieldInfoPtr_m_Master), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000671 RID: 1649
		private static readonly IntPtr NativeFieldInfoPtr_ClassName;

		// Token: 0x04000672 RID: 1650
		private static readonly IntPtr NativeFieldInfoPtr_m_Contribution;

		// Token: 0x04000673 RID: 1651
		private static readonly IntPtr NativeFieldInfoPtr_m_CookieTexture;

		// Token: 0x04000674 RID: 1652
		private static readonly IntPtr NativeFieldInfoPtr_m_Channel;

		// Token: 0x04000675 RID: 1653
		private static readonly IntPtr NativeFieldInfoPtr_m_Negative;

		// Token: 0x04000676 RID: 1654
		private static readonly IntPtr NativeFieldInfoPtr_m_Translation;

		// Token: 0x04000677 RID: 1655
		private static readonly IntPtr NativeFieldInfoPtr_m_Rotation;

		// Token: 0x04000678 RID: 1656
		private static readonly IntPtr NativeFieldInfoPtr_m_Scale;

		// Token: 0x04000679 RID: 1657
		private static readonly IntPtr NativeFieldInfoPtr_m_Master;

		// Token: 0x0400067A RID: 1658
		private static readonly IntPtr NativeMethodInfoPtr_get_contribution_Public_get_Single_0;

		// Token: 0x0400067B RID: 1659
		private static readonly IntPtr NativeMethodInfoPtr_set_contribution_Public_set_Void_Single_0;

		// Token: 0x0400067C RID: 1660
		private static readonly IntPtr NativeMethodInfoPtr_get_cookieTexture_Public_get_Texture_0;

		// Token: 0x0400067D RID: 1661
		private static readonly IntPtr NativeMethodInfoPtr_set_cookieTexture_Public_set_Void_Texture_0;

		// Token: 0x0400067E RID: 1662
		private static readonly IntPtr NativeMethodInfoPtr_get_channel_Public_get_CookieChannel_0;

		// Token: 0x0400067F RID: 1663
		private static readonly IntPtr NativeMethodInfoPtr_set_channel_Public_set_Void_CookieChannel_0;

		// Token: 0x04000680 RID: 1664
		private static readonly IntPtr NativeMethodInfoPtr_get_negative_Public_get_Boolean_0;

		// Token: 0x04000681 RID: 1665
		private static readonly IntPtr NativeMethodInfoPtr_set_negative_Public_set_Void_Boolean_0;

		// Token: 0x04000682 RID: 1666
		private static readonly IntPtr NativeMethodInfoPtr_get_translation_Public_get_Vector2_0;

		// Token: 0x04000683 RID: 1667
		private static readonly IntPtr NativeMethodInfoPtr_set_translation_Public_set_Void_Vector2_0;

		// Token: 0x04000684 RID: 1668
		private static readonly IntPtr NativeMethodInfoPtr_get_rotation_Public_get_Single_0;

		// Token: 0x04000685 RID: 1669
		private static readonly IntPtr NativeMethodInfoPtr_set_rotation_Public_set_Void_Single_0;

		// Token: 0x04000686 RID: 1670
		private static readonly IntPtr NativeMethodInfoPtr_get_scale_Public_get_Vector2_0;

		// Token: 0x04000687 RID: 1671
		private static readonly IntPtr NativeMethodInfoPtr_set_scale_Public_set_Void_Vector2_0;

		// Token: 0x04000688 RID: 1672
		private static readonly IntPtr NativeMethodInfoPtr_SetDirty_Private_Void_0;

		// Token: 0x04000689 RID: 1673
		private static readonly IntPtr NativeMethodInfoPtr_ApplyMaterialProperties_Public_Static_Void_VolumetricCookieHD_BeamGeometryHD_0;

		// Token: 0x0400068A RID: 1674
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400068B RID: 1675
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x0400068C RID: 1676
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x0400068D RID: 1677
		private static readonly IntPtr NativeMethodInfoPtr_OnDidApplyAnimationProperties_Private_Void_0;

		// Token: 0x0400068E RID: 1678
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400068F RID: 1679
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04000690 RID: 1680
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
