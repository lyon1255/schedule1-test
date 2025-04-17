using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200063A RID: 1594
	public class Flipboard : MonoBehaviour
	{
		// Token: 0x06008CD7 RID: 36055 RVA: 0x0024BD94 File Offset: 0x00249F94
		// Note: this type is marked as 'beforefieldinit'.
		static Flipboard()
		{
			Il2CppClassPointerStore<Flipboard>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "Flipboard");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Flipboard>.NativeClassPtr);
			Flipboard.NativeFieldInfoPtr_Sprites = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Flipboard>.NativeClassPtr, "Sprites");
			Flipboard.NativeFieldInfoPtr_Image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Flipboard>.NativeClassPtr, "Image");
			Flipboard.NativeFieldInfoPtr_FlipTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Flipboard>.NativeClassPtr, "FlipTime");
			Flipboard.NativeFieldInfoPtr_SpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Flipboard>.NativeClassPtr, "SpeedMultiplier");
			Flipboard.NativeFieldInfoPtr_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Flipboard>.NativeClassPtr, "time");
			Flipboard.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Flipboard>.NativeClassPtr, "index");
			Flipboard.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Flipboard>.NativeClassPtr, 100680794);
			Flipboard.NativeMethodInfoPtr_SetIndex_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Flipboard>.NativeClassPtr, 100680795);
			Flipboard.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Flipboard>.NativeClassPtr, 100680796);
		}

		// Token: 0x06008CD8 RID: 36056 RVA: 0x0024BE78 File Offset: 0x0024A078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257114, XrefRangeEnd = 257116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Flipboard.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008CD9 RID: 36057 RVA: 0x0024BEAC File Offset: 0x0024A0AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 257119, RefRangeEnd = 257120, XrefRangeStart = 257116, XrefRangeEnd = 257119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIndex(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Flipboard.NativeMethodInfoPtr_SetIndex_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008CDA RID: 36058 RVA: 0x0024BEEC File Offset: 0x0024A0EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257120, XrefRangeEnd = 257121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Flipboard() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Flipboard>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Flipboard.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008CDB RID: 36059 RVA: 0x000438CF File Offset: 0x00041ACF
		public Flipboard(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002AF5 RID: 10997
		// (get) Token: 0x06008CDC RID: 36060 RVA: 0x0024BF28 File Offset: 0x0024A128
		// (set) Token: 0x06008CDD RID: 36061 RVA: 0x000438D8 File Offset: 0x00041AD8
		public unsafe Il2CppReferenceArray<Sprite> Sprites
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Flipboard.NativeFieldInfoPtr_Sprites);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Sprite>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Flipboard.NativeFieldInfoPtr_Sprites), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AF6 RID: 10998
		// (get) Token: 0x06008CDE RID: 36062 RVA: 0x0024BF58 File Offset: 0x0024A158
		// (set) Token: 0x06008CDF RID: 36063 RVA: 0x000438F7 File Offset: 0x00041AF7
		public unsafe Image Image
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Flipboard.NativeFieldInfoPtr_Image);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Flipboard.NativeFieldInfoPtr_Image), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AF7 RID: 10999
		// (get) Token: 0x06008CE0 RID: 36064 RVA: 0x0024BF88 File Offset: 0x0024A188
		// (set) Token: 0x06008CE1 RID: 36065 RVA: 0x00043916 File Offset: 0x00041B16
		public unsafe float FlipTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Flipboard.NativeFieldInfoPtr_FlipTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Flipboard.NativeFieldInfoPtr_FlipTime)) = value;
			}
		}

		// Token: 0x17002AF8 RID: 11000
		// (get) Token: 0x06008CE2 RID: 36066 RVA: 0x0024BFB0 File Offset: 0x0024A1B0
		// (set) Token: 0x06008CE3 RID: 36067 RVA: 0x00043931 File Offset: 0x00041B31
		public unsafe float SpeedMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Flipboard.NativeFieldInfoPtr_SpeedMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Flipboard.NativeFieldInfoPtr_SpeedMultiplier)) = value;
			}
		}

		// Token: 0x17002AF9 RID: 11001
		// (get) Token: 0x06008CE4 RID: 36068 RVA: 0x0024BFD8 File Offset: 0x0024A1D8
		// (set) Token: 0x06008CE5 RID: 36069 RVA: 0x0004394C File Offset: 0x00041B4C
		public unsafe float time
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Flipboard.NativeFieldInfoPtr_time);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Flipboard.NativeFieldInfoPtr_time)) = value;
			}
		}

		// Token: 0x17002AFA RID: 11002
		// (get) Token: 0x06008CE6 RID: 36070 RVA: 0x0024C000 File Offset: 0x0024A200
		// (set) Token: 0x06008CE7 RID: 36071 RVA: 0x00043967 File Offset: 0x00041B67
		public unsafe int index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Flipboard.NativeFieldInfoPtr_index);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Flipboard.NativeFieldInfoPtr_index)) = value;
			}
		}

		// Token: 0x04005F71 RID: 24433
		private static readonly IntPtr NativeFieldInfoPtr_Sprites;

		// Token: 0x04005F72 RID: 24434
		private static readonly IntPtr NativeFieldInfoPtr_Image;

		// Token: 0x04005F73 RID: 24435
		private static readonly IntPtr NativeFieldInfoPtr_FlipTime;

		// Token: 0x04005F74 RID: 24436
		private static readonly IntPtr NativeFieldInfoPtr_SpeedMultiplier;

		// Token: 0x04005F75 RID: 24437
		private static readonly IntPtr NativeFieldInfoPtr_time;

		// Token: 0x04005F76 RID: 24438
		private static readonly IntPtr NativeFieldInfoPtr_index;

		// Token: 0x04005F77 RID: 24439
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x04005F78 RID: 24440
		private static readonly IntPtr NativeMethodInfoPtr_SetIndex_Public_Void_Int32_0;

		// Token: 0x04005F79 RID: 24441
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
