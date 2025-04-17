using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppAdvancedPeopleSystem
{
	// Token: 0x0200014C RID: 332
	[Serializable]
	public class MinMaxIndex : Object
	{
		// Token: 0x06001B8B RID: 7051 RVA: 0x000C6858 File Offset: 0x000C4A58
		// Note: this type is marked as 'beforefieldinit'.
		static MinMaxIndex()
		{
			Il2CppClassPointerStore<MinMaxIndex>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "AdvancedPeopleSystem", "MinMaxIndex");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MinMaxIndex>.NativeClassPtr);
			MinMaxIndex.NativeFieldInfoPtr_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinMaxIndex>.NativeClassPtr, "Min");
			MinMaxIndex.NativeFieldInfoPtr_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinMaxIndex>.NativeClassPtr, "Max");
			MinMaxIndex.NativeMethodInfoPtr_GetRandom_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxIndex>.NativeClassPtr, 100666224);
			MinMaxIndex.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxIndex>.NativeClassPtr, 100666225);
		}

		// Token: 0x06001B8C RID: 7052 RVA: 0x000C68D8 File Offset: 0x000C4AD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100446, XrefRangeEnd = 100447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetRandom(int max)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxIndex.NativeMethodInfoPtr_GetRandom_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B8D RID: 7053 RVA: 0x000C6924 File Offset: 0x000C4B24
		[CallerCount(2259)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MinMaxIndex() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MinMaxIndex>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinMaxIndex.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B8E RID: 7054 RVA: 0x0000F99E File Offset: 0x0000DB9E
		public MinMaxIndex(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700099E RID: 2462
		// (get) Token: 0x06001B8F RID: 7055 RVA: 0x000C6960 File Offset: 0x000C4B60
		// (set) Token: 0x06001B90 RID: 7056 RVA: 0x0000F9A7 File Offset: 0x0000DBA7
		public unsafe int Min
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinMaxIndex.NativeFieldInfoPtr_Min);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinMaxIndex.NativeFieldInfoPtr_Min)) = value;
			}
		}

		// Token: 0x1700099F RID: 2463
		// (get) Token: 0x06001B91 RID: 7057 RVA: 0x000C6988 File Offset: 0x000C4B88
		// (set) Token: 0x06001B92 RID: 7058 RVA: 0x0000F9C2 File Offset: 0x0000DBC2
		public unsafe int Max
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinMaxIndex.NativeFieldInfoPtr_Max);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinMaxIndex.NativeFieldInfoPtr_Max)) = value;
			}
		}

		// Token: 0x0400121F RID: 4639
		private static readonly IntPtr NativeFieldInfoPtr_Min;

		// Token: 0x04001220 RID: 4640
		private static readonly IntPtr NativeFieldInfoPtr_Max;

		// Token: 0x04001221 RID: 4641
		private static readonly IntPtr NativeMethodInfoPtr_GetRandom_Public_Int32_Int32_0;

		// Token: 0x04001222 RID: 4642
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
