using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppAdvancedPeopleSystem
{
	// Token: 0x02000152 RID: 338
	[Serializable]
	public class MinMaxFacialBlendshapes : Object
	{
		// Token: 0x06001BB3 RID: 7091 RVA: 0x000C6E84 File Offset: 0x000C5084
		// Note: this type is marked as 'beforefieldinit'.
		static MinMaxFacialBlendshapes()
		{
			Il2CppClassPointerStore<MinMaxFacialBlendshapes>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "AdvancedPeopleSystem", "MinMaxFacialBlendshapes");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MinMaxFacialBlendshapes>.NativeClassPtr);
			MinMaxFacialBlendshapes.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinMaxFacialBlendshapes>.NativeClassPtr, "name");
			MinMaxFacialBlendshapes.NativeFieldInfoPtr_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinMaxFacialBlendshapes>.NativeClassPtr, "Min");
			MinMaxFacialBlendshapes.NativeFieldInfoPtr_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinMaxFacialBlendshapes>.NativeClassPtr, "Max");
			MinMaxFacialBlendshapes.NativeMethodInfoPtr_GetRandom_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxFacialBlendshapes>.NativeClassPtr, 100666232);
			MinMaxFacialBlendshapes.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxFacialBlendshapes>.NativeClassPtr, 100666233);
		}

		// Token: 0x06001BB4 RID: 7092 RVA: 0x000C6F18 File Offset: 0x000C5118
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100484, XrefRangeEnd = 100485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetRandom()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxFacialBlendshapes.NativeMethodInfoPtr_GetRandom_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BB5 RID: 7093 RVA: 0x000C6F54 File Offset: 0x000C5154
		[CallerCount(2259)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MinMaxFacialBlendshapes() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MinMaxFacialBlendshapes>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxFacialBlendshapes.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BB6 RID: 7094 RVA: 0x0000FB00 File Offset: 0x0000DD00
		public MinMaxFacialBlendshapes(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170009A9 RID: 2473
		// (get) Token: 0x06001BB7 RID: 7095 RVA: 0x000C6F90 File Offset: 0x000C5190
		// (set) Token: 0x06001BB8 RID: 7096 RVA: 0x0000FB09 File Offset: 0x0000DD09
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinMaxFacialBlendshapes.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinMaxFacialBlendshapes.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170009AA RID: 2474
		// (get) Token: 0x06001BB9 RID: 7097 RVA: 0x000C6FB8 File Offset: 0x000C51B8
		// (set) Token: 0x06001BBA RID: 7098 RVA: 0x0000FB28 File Offset: 0x0000DD28
		public unsafe float Min
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinMaxFacialBlendshapes.NativeFieldInfoPtr_Min);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinMaxFacialBlendshapes.NativeFieldInfoPtr_Min)) = value;
			}
		}

		// Token: 0x170009AB RID: 2475
		// (get) Token: 0x06001BBB RID: 7099 RVA: 0x000C6FE0 File Offset: 0x000C51E0
		// (set) Token: 0x06001BBC RID: 7100 RVA: 0x0000FB43 File Offset: 0x0000DD43
		public unsafe float Max
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinMaxFacialBlendshapes.NativeFieldInfoPtr_Max);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinMaxFacialBlendshapes.NativeFieldInfoPtr_Max)) = value;
			}
		}

		// Token: 0x0400123A RID: 4666
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x0400123B RID: 4667
		private static readonly IntPtr NativeFieldInfoPtr_Min;

		// Token: 0x0400123C RID: 4668
		private static readonly IntPtr NativeFieldInfoPtr_Max;

		// Token: 0x0400123D RID: 4669
		private static readonly IntPtr NativeMethodInfoPtr_GetRandom_Public_Single_0;

		// Token: 0x0400123E RID: 4670
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
