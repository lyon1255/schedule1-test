using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppAdvancedPeopleSystem
{
	// Token: 0x0200014D RID: 333
	[Serializable]
	public class MinMaxColor : Il2CppSystem.Object
	{
		// Token: 0x06001B93 RID: 7059 RVA: 0x000C69B0 File Offset: 0x000C4BB0
		// Note: this type is marked as 'beforefieldinit'.
		static MinMaxColor()
		{
			Il2CppClassPointerStore<MinMaxColor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "AdvancedPeopleSystem", "MinMaxColor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MinMaxColor>.NativeClassPtr);
			MinMaxColor.NativeFieldInfoPtr_minColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinMaxColor>.NativeClassPtr, "minColors");
			MinMaxColor.NativeFieldInfoPtr_maxColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinMaxColor>.NativeClassPtr, "maxColors");
			MinMaxColor.NativeMethodInfoPtr_GetRandom_Public_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxColor>.NativeClassPtr, 100666226);
			MinMaxColor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxColor>.NativeClassPtr, 100666227);
		}

		// Token: 0x06001B94 RID: 7060 RVA: 0x000C6A30 File Offset: 0x000C4C30
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 100456, RefRangeEnd = 100459, XrefRangeStart = 100447, XrefRangeEnd = 100456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Color GetRandom()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxColor.NativeMethodInfoPtr_GetRandom_Public_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B95 RID: 7061 RVA: 0x000C6A6C File Offset: 0x000C4C6C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 100472, RefRangeEnd = 100475, XrefRangeStart = 100459, XrefRangeEnd = 100472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MinMaxColor() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MinMaxColor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxColor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B96 RID: 7062 RVA: 0x0000F9DD File Offset: 0x0000DBDD
		public MinMaxColor(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170009A0 RID: 2464
		// (get) Token: 0x06001B97 RID: 7063 RVA: 0x000C6AA8 File Offset: 0x000C4CA8
		// (set) Token: 0x06001B98 RID: 7064 RVA: 0x0000F9E6 File Offset: 0x0000DBE6
		public unsafe List<Color> minColors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinMaxColor.NativeFieldInfoPtr_minColors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Color>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinMaxColor.NativeFieldInfoPtr_minColors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009A1 RID: 2465
		// (get) Token: 0x06001B99 RID: 7065 RVA: 0x000C6AD8 File Offset: 0x000C4CD8
		// (set) Token: 0x06001B9A RID: 7066 RVA: 0x0000FA05 File Offset: 0x0000DC05
		public unsafe List<Color> maxColors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinMaxColor.NativeFieldInfoPtr_maxColors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Color>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinMaxColor.NativeFieldInfoPtr_maxColors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001223 RID: 4643
		private static readonly IntPtr NativeFieldInfoPtr_minColors;

		// Token: 0x04001224 RID: 4644
		private static readonly IntPtr NativeFieldInfoPtr_maxColors;

		// Token: 0x04001225 RID: 4645
		private static readonly IntPtr NativeMethodInfoPtr_GetRandom_Public_Color_0;

		// Token: 0x04001226 RID: 4646
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
