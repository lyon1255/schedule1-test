using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppAdvancedPeopleSystem
{
	// Token: 0x0200014E RID: 334
	[Serializable]
	public class MinMaxBlendshapes : Object
	{
		// Token: 0x06001B9B RID: 7067 RVA: 0x000C6B08 File Offset: 0x000C4D08
		// Note: this type is marked as 'beforefieldinit'.
		static MinMaxBlendshapes()
		{
			Il2CppClassPointerStore<MinMaxBlendshapes>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "AdvancedPeopleSystem", "MinMaxBlendshapes");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MinMaxBlendshapes>.NativeClassPtr);
			MinMaxBlendshapes.NativeFieldInfoPtr_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinMaxBlendshapes>.NativeClassPtr, "Min");
			MinMaxBlendshapes.NativeFieldInfoPtr_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinMaxBlendshapes>.NativeClassPtr, "Max");
			MinMaxBlendshapes.NativeMethodInfoPtr_GetRandom_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxBlendshapes>.NativeClassPtr, 100666228);
			MinMaxBlendshapes.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxBlendshapes>.NativeClassPtr, 100666229);
		}

		// Token: 0x06001B9C RID: 7068 RVA: 0x000C6B88 File Offset: 0x000C4D88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100475, XrefRangeEnd = 100476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetRandom()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxBlendshapes.NativeMethodInfoPtr_GetRandom_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B9D RID: 7069 RVA: 0x000C6BC4 File Offset: 0x000C4DC4
		[CallerCount(2259)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MinMaxBlendshapes() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MinMaxBlendshapes>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxBlendshapes.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B9E RID: 7070 RVA: 0x0000FA24 File Offset: 0x0000DC24
		public MinMaxBlendshapes(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170009A2 RID: 2466
		// (get) Token: 0x06001B9F RID: 7071 RVA: 0x000C6C00 File Offset: 0x000C4E00
		// (set) Token: 0x06001BA0 RID: 7072 RVA: 0x0000FA2D File Offset: 0x0000DC2D
		public unsafe float Min
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinMaxBlendshapes.NativeFieldInfoPtr_Min);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinMaxBlendshapes.NativeFieldInfoPtr_Min)) = value;
			}
		}

		// Token: 0x170009A3 RID: 2467
		// (get) Token: 0x06001BA1 RID: 7073 RVA: 0x000C6C28 File Offset: 0x000C4E28
		// (set) Token: 0x06001BA2 RID: 7074 RVA: 0x0000FA48 File Offset: 0x0000DC48
		public unsafe float Max
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinMaxBlendshapes.NativeFieldInfoPtr_Max);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinMaxBlendshapes.NativeFieldInfoPtr_Max)) = value;
			}
		}

		// Token: 0x04001227 RID: 4647
		private static readonly IntPtr NativeFieldInfoPtr_Min;

		// Token: 0x04001228 RID: 4648
		private static readonly IntPtr NativeFieldInfoPtr_Max;

		// Token: 0x04001229 RID: 4649
		private static readonly IntPtr NativeMethodInfoPtr_GetRandom_Public_Single_0;

		// Token: 0x0400122A RID: 4650
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
