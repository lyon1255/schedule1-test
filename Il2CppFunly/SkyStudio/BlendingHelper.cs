using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x020000E6 RID: 230
	public class BlendingHelper : Il2CppSystem.Object
	{
		// Token: 0x06001230 RID: 4656 RVA: 0x000A9664 File Offset: 0x000A7864
		// Note: this type is marked as 'beforefieldinit'.
		static BlendingHelper()
		{
			Il2CppClassPointerStore<BlendingHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "BlendingHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlendingHelper>.NativeClassPtr);
			BlendingHelper.NativeFieldInfoPtr_m_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendingHelper>.NativeClassPtr, "m_State");
			BlendingHelper.NativeMethodInfoPtr__ctor_Public_Void_ProfileBlendingState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendingHelper>.NativeClassPtr, 100665372);
			BlendingHelper.NativeMethodInfoPtr_UpdateState_Public_Void_ProfileBlendingState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendingHelper>.NativeClassPtr, 100665373);
			BlendingHelper.NativeMethodInfoPtr_ProfileColorForKey_Public_Color_SkyProfile_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendingHelper>.NativeClassPtr, 100665374);
			BlendingHelper.NativeMethodInfoPtr_ProfileNumberForKey_Public_Single_SkyProfile_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendingHelper>.NativeClassPtr, 100665375);
			BlendingHelper.NativeMethodInfoPtr_ProfileSpherePointForKey_Public_SpherePoint_SkyProfile_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendingHelper>.NativeClassPtr, 100665376);
			BlendingHelper.NativeMethodInfoPtr_BlendColor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendingHelper>.NativeClassPtr, 100665377);
			BlendingHelper.NativeMethodInfoPtr_BlendColorOut_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendingHelper>.NativeClassPtr, 100665378);
			BlendingHelper.NativeMethodInfoPtr_BlendColorIn_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendingHelper>.NativeClassPtr, 100665379);
			BlendingHelper.NativeMethodInfoPtr_BlendColor_Public_Void_String_Color_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendingHelper>.NativeClassPtr, 100665380);
			BlendingHelper.NativeMethodInfoPtr_BlendNumber_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendingHelper>.NativeClassPtr, 100665381);
			BlendingHelper.NativeMethodInfoPtr_BlendNumberOut_Public_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendingHelper>.NativeClassPtr, 100665382);
			BlendingHelper.NativeMethodInfoPtr_BlendNumberIn_Public_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendingHelper>.NativeClassPtr, 100665383);
			BlendingHelper.NativeMethodInfoPtr_BlendNumber_Public_Void_String_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendingHelper>.NativeClassPtr, 100665384);
			BlendingHelper.NativeMethodInfoPtr_BlendSpherePoint_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendingHelper>.NativeClassPtr, 100665385);
			BlendingHelper.NativeMethodInfoPtr_BlendSpherePoint_Public_Void_String_SpherePoint_SpherePoint_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendingHelper>.NativeClassPtr, 100665386);
			BlendingHelper.NativeMethodInfoPtr_GetFeatureAnimationMode_Public_ProfileFeatureBlendingMode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendingHelper>.NativeClassPtr, 100665387);
		}

		// Token: 0x06001231 RID: 4657 RVA: 0x000A97E8 File Offset: 0x000A79E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88928, XrefRangeEnd = 88930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BlendingHelper(ProfileBlendingState state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlendingHelper>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(state));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlendingHelper.NativeMethodInfoPtr__ctor_Public_Void_ProfileBlendingState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001232 RID: 4658 RVA: 0x000A9838 File Offset: 0x000A7A38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88930, XrefRangeEnd = 88931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateState(ProfileBlendingState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(state));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlendingHelper.NativeMethodInfoPtr_UpdateState_Public_Void_ProfileBlendingState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001233 RID: 4659 RVA: 0x000A9880 File Offset: 0x000A7A80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88931, XrefRangeEnd = 88940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Color ProfileColorForKey(SkyProfile profile, string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(profile);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlendingHelper.NativeMethodInfoPtr_ProfileColorForKey_Public_Color_SkyProfile_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001234 RID: 4660 RVA: 0x000A98E0 File Offset: 0x000A7AE0
		[CallerCount(132)]
		[CachedScanResults(RefRangeStart = 88950, RefRangeEnd = 89082, XrefRangeStart = 88940, XrefRangeEnd = 88950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float ProfileNumberForKey(SkyProfile profile, string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(profile);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlendingHelper.NativeMethodInfoPtr_ProfileNumberForKey_Public_Single_SkyProfile_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001235 RID: 4661 RVA: 0x000A9940 File Offset: 0x000A7B40
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 89092, RefRangeEnd = 89094, XrefRangeStart = 89082, XrefRangeEnd = 89092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpherePoint ProfileSpherePointForKey(SkyProfile profile, string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(profile);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlendingHelper.NativeMethodInfoPtr_ProfileSpherePointForKey_Public_SpherePoint_SkyProfile_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SpherePoint>(intPtr3) : null;
		}

		// Token: 0x06001236 RID: 4662 RVA: 0x000A99A4 File Offset: 0x000A7BA4
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 89112, RefRangeEnd = 89135, XrefRangeStart = 89094, XrefRangeEnd = 89112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BlendColor(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlendingHelper.NativeMethodInfoPtr_BlendColor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001237 RID: 4663 RVA: 0x000A99E8 File Offset: 0x000A7BE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89135, XrefRangeEnd = 89153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BlendColorOut(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlendingHelper.NativeMethodInfoPtr_BlendColorOut_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001238 RID: 4664 RVA: 0x000A9A2C File Offset: 0x000A7C2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89153, XrefRangeEnd = 89171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BlendColorIn(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlendingHelper.NativeMethodInfoPtr_BlendColorIn_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001239 RID: 4665 RVA: 0x000A9A70 File Offset: 0x000A7C70
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 89177, RefRangeEnd = 89180, XrefRangeStart = 89171, XrefRangeEnd = 89177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BlendColor(string key, Color from, Color to, float progress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref from;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref progress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlendingHelper.NativeMethodInfoPtr_BlendColor_Public_Void_String_Color_Color_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600123A RID: 4666 RVA: 0x000A9ADC File Offset: 0x000A7CDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89180, XrefRangeEnd = 89183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BlendNumber(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlendingHelper.NativeMethodInfoPtr_BlendNumber_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600123B RID: 4667 RVA: 0x000A9B20 File Offset: 0x000A7D20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89183, XrefRangeEnd = 89185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BlendNumberOut(string key, float toValue = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref toValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlendingHelper.NativeMethodInfoPtr_BlendNumberOut_Public_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600123C RID: 4668 RVA: 0x000A9B70 File Offset: 0x000A7D70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89185, XrefRangeEnd = 89187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BlendNumberIn(string key, float fromValue = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlendingHelper.NativeMethodInfoPtr_BlendNumberIn_Public_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600123D RID: 4669 RVA: 0x000A9BC0 File Offset: 0x000A7DC0
		[CallerCount(79)]
		[CachedScanResults(RefRangeStart = 89194, RefRangeEnd = 89273, XrefRangeStart = 89187, XrefRangeEnd = 89194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BlendNumber(string key, float from, float to, float progress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref from;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref progress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlendingHelper.NativeMethodInfoPtr_BlendNumber_Public_Void_String_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600123E RID: 4670 RVA: 0x000A9C2C File Offset: 0x000A7E2C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 89294, RefRangeEnd = 89296, XrefRangeStart = 89273, XrefRangeEnd = 89294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BlendSpherePoint(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlendingHelper.NativeMethodInfoPtr_BlendSpherePoint_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600123F RID: 4671 RVA: 0x000A9C70 File Offset: 0x000A7E70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89296, XrefRangeEnd = 89312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BlendSpherePoint(string key, SpherePoint from, SpherePoint to, float progress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(from);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(to);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref progress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlendingHelper.NativeMethodInfoPtr_BlendSpherePoint_Public_Void_String_SpherePoint_SpherePoint_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001240 RID: 4672 RVA: 0x000A9CE4 File Offset: 0x000A7EE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89312, XrefRangeEnd = 89314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProfileFeatureBlendingMode GetFeatureAnimationMode(string featureKey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(featureKey);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlendingHelper.NativeMethodInfoPtr_GetFeatureAnimationMode_Public_ProfileFeatureBlendingMode_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001241 RID: 4673 RVA: 0x0000B11A File Offset: 0x0000931A
		public BlendingHelper(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x06001242 RID: 4674 RVA: 0x000A9D34 File Offset: 0x000A7F34
		// (set) Token: 0x06001243 RID: 4675 RVA: 0x0000B123 File Offset: 0x00009323
		public ProfileBlendingState m_State
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlendingHelper.NativeFieldInfoPtr_m_State);
				return new ProfileBlendingState(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProfileBlendingState>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlendingHelper.NativeFieldInfoPtr_m_State), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ProfileBlendingState>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000C11 RID: 3089
		private static readonly IntPtr NativeFieldInfoPtr_m_State;

		// Token: 0x04000C12 RID: 3090
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ProfileBlendingState_0;

		// Token: 0x04000C13 RID: 3091
		private static readonly IntPtr NativeMethodInfoPtr_UpdateState_Public_Void_ProfileBlendingState_0;

		// Token: 0x04000C14 RID: 3092
		private static readonly IntPtr NativeMethodInfoPtr_ProfileColorForKey_Public_Color_SkyProfile_String_0;

		// Token: 0x04000C15 RID: 3093
		private static readonly IntPtr NativeMethodInfoPtr_ProfileNumberForKey_Public_Single_SkyProfile_String_0;

		// Token: 0x04000C16 RID: 3094
		private static readonly IntPtr NativeMethodInfoPtr_ProfileSpherePointForKey_Public_SpherePoint_SkyProfile_String_0;

		// Token: 0x04000C17 RID: 3095
		private static readonly IntPtr NativeMethodInfoPtr_BlendColor_Public_Void_String_0;

		// Token: 0x04000C18 RID: 3096
		private static readonly IntPtr NativeMethodInfoPtr_BlendColorOut_Public_Void_String_0;

		// Token: 0x04000C19 RID: 3097
		private static readonly IntPtr NativeMethodInfoPtr_BlendColorIn_Public_Void_String_0;

		// Token: 0x04000C1A RID: 3098
		private static readonly IntPtr NativeMethodInfoPtr_BlendColor_Public_Void_String_Color_Color_Single_0;

		// Token: 0x04000C1B RID: 3099
		private static readonly IntPtr NativeMethodInfoPtr_BlendNumber_Public_Void_String_0;

		// Token: 0x04000C1C RID: 3100
		private static readonly IntPtr NativeMethodInfoPtr_BlendNumberOut_Public_Void_String_Single_0;

		// Token: 0x04000C1D RID: 3101
		private static readonly IntPtr NativeMethodInfoPtr_BlendNumberIn_Public_Void_String_Single_0;

		// Token: 0x04000C1E RID: 3102
		private static readonly IntPtr NativeMethodInfoPtr_BlendNumber_Public_Void_String_Single_Single_Single_0;

		// Token: 0x04000C1F RID: 3103
		private static readonly IntPtr NativeMethodInfoPtr_BlendSpherePoint_Public_Void_String_0;

		// Token: 0x04000C20 RID: 3104
		private static readonly IntPtr NativeMethodInfoPtr_BlendSpherePoint_Public_Void_String_SpherePoint_SpherePoint_Single_0;

		// Token: 0x04000C21 RID: 3105
		private static readonly IntPtr NativeMethodInfoPtr_GetFeatureAnimationMode_Public_ProfileFeatureBlendingMode_String_0;
	}
}
