using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x020000EF RID: 239
	public class StarBlender : FeatureBlender
	{
		// Token: 0x06001279 RID: 4729 RVA: 0x000AADE8 File Offset: 0x000A8FE8
		// Note: this type is marked as 'beforefieldinit'.
		static StarBlender()
		{
			Il2CppClassPointerStore<StarBlender>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "StarBlender");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StarBlender>.NativeClassPtr);
			StarBlender.NativeFieldInfoPtr_starLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StarBlender>.NativeClassPtr, "starLayer");
			StarBlender.NativeMethodInfoPtr_get_featureKey_Protected_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StarBlender>.NativeClassPtr, 100665425);
			StarBlender.NativeMethodInfoPtr_BlendBoth_Protected_Virtual_Void_ProfileBlendingState_BlendingHelper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StarBlender>.NativeClassPtr, 100665426);
			StarBlender.NativeMethodInfoPtr_BlendIn_Protected_Virtual_Void_ProfileBlendingState_BlendingHelper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StarBlender>.NativeClassPtr, 100665427);
			StarBlender.NativeMethodInfoPtr_BlendOut_Protected_Virtual_Void_ProfileBlendingState_BlendingHelper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StarBlender>.NativeClassPtr, 100665428);
			StarBlender.NativeMethodInfoPtr_PropertyKeyForLayer_Private_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StarBlender>.NativeClassPtr, 100665429);
			StarBlender.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StarBlender>.NativeClassPtr, 100665430);
		}

		// Token: 0x1700064B RID: 1611
		// (get) Token: 0x0600127A RID: 4730 RVA: 0x000AAEA4 File Offset: 0x000A90A4
		public unsafe override string featureKey
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89675, XrefRangeEnd = 89681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StarBlender.NativeMethodInfoPtr_get_featureKey_Protected_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600127B RID: 4731 RVA: 0x000AAEE8 File Offset: 0x000A90E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89681, XrefRangeEnd = 89763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void BlendBoth(ProfileBlendingState state, BlendingHelper helper)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(state));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(helper);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StarBlender.NativeMethodInfoPtr_BlendBoth_Protected_Virtual_Void_ProfileBlendingState_BlendingHelper_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600127C RID: 4732 RVA: 0x000AAF4C File Offset: 0x000A914C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89763, XrefRangeEnd = 89774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void BlendIn(ProfileBlendingState state, BlendingHelper helper)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(state));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(helper);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StarBlender.NativeMethodInfoPtr_BlendIn_Protected_Virtual_Void_ProfileBlendingState_BlendingHelper_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600127D RID: 4733 RVA: 0x000AAFB0 File Offset: 0x000A91B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89774, XrefRangeEnd = 89785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void BlendOut(ProfileBlendingState state, BlendingHelper helper)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(state));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(helper);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StarBlender.NativeMethodInfoPtr_BlendOut_Protected_Virtual_Void_ProfileBlendingState_BlendingHelper_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600127E RID: 4734 RVA: 0x000AB014 File Offset: 0x000A9214
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89785, XrefRangeEnd = 89793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string PropertyKeyForLayer(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StarBlender.NativeMethodInfoPtr_PropertyKeyForLayer_Private_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600127F RID: 4735 RVA: 0x000AB05C File Offset: 0x000A925C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StarBlender() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StarBlender>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StarBlender.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001280 RID: 4736 RVA: 0x0000B1D2 File Offset: 0x000093D2
		public StarBlender(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700064A RID: 1610
		// (get) Token: 0x06001281 RID: 4737 RVA: 0x000AB098 File Offset: 0x000A9298
		// (set) Token: 0x06001282 RID: 4738 RVA: 0x0000B1DB File Offset: 0x000093DB
		public unsafe int starLayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StarBlender.NativeFieldInfoPtr_starLayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StarBlender.NativeFieldInfoPtr_starLayer)) = value;
			}
		}

		// Token: 0x04000C47 RID: 3143
		private static readonly IntPtr NativeFieldInfoPtr_starLayer;

		// Token: 0x04000C48 RID: 3144
		private static readonly IntPtr NativeMethodInfoPtr_get_featureKey_Protected_Virtual_get_String_0;

		// Token: 0x04000C49 RID: 3145
		private static readonly IntPtr NativeMethodInfoPtr_BlendBoth_Protected_Virtual_Void_ProfileBlendingState_BlendingHelper_0;

		// Token: 0x04000C4A RID: 3146
		private static readonly IntPtr NativeMethodInfoPtr_BlendIn_Protected_Virtual_Void_ProfileBlendingState_BlendingHelper_0;

		// Token: 0x04000C4B RID: 3147
		private static readonly IntPtr NativeMethodInfoPtr_BlendOut_Protected_Virtual_Void_ProfileBlendingState_BlendingHelper_0;

		// Token: 0x04000C4C RID: 3148
		private static readonly IntPtr NativeMethodInfoPtr_PropertyKeyForLayer_Private_String_String_0;

		// Token: 0x04000C4D RID: 3149
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
