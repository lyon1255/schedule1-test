using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework.Customization
{
	// Token: 0x02000612 RID: 1554
	public class ACEntry : MonoBehaviour
	{
		// Token: 0x06008950 RID: 35152 RVA: 0x002412C0 File Offset: 0x0023F4C0
		// Note: this type is marked as 'beforefieldinit'.
		static ACEntry()
		{
			Il2CppClassPointerStore<ACEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Customization", "ACEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ACEntry>.NativeClassPtr);
			ACEntry.NativeFieldInfoPtr_DevOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACEntry>.NativeClassPtr, "DevOnly");
			ACEntry.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACEntry>.NativeClassPtr, 100680394);
			ACEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACEntry>.NativeClassPtr, 100680395);
		}

		// Token: 0x06008951 RID: 35153 RVA: 0x0024132C File Offset: 0x0023F52C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253209, XrefRangeEnd = 253215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACEntry.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008952 RID: 35154 RVA: 0x00241360 File Offset: 0x0023F560
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ACEntry() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ACEntry>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008953 RID: 35155 RVA: 0x000418E8 File Offset: 0x0003FAE8
		public ACEntry(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170029D8 RID: 10712
		// (get) Token: 0x06008954 RID: 35156 RVA: 0x0024139C File Offset: 0x0023F59C
		// (set) Token: 0x06008955 RID: 35157 RVA: 0x000418F1 File Offset: 0x0003FAF1
		public unsafe bool DevOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACEntry.NativeFieldInfoPtr_DevOnly);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACEntry.NativeFieldInfoPtr_DevOnly)) = value;
			}
		}

		// Token: 0x04005D3F RID: 23871
		private static readonly IntPtr NativeFieldInfoPtr_DevOnly;

		// Token: 0x04005D40 RID: 23872
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04005D41 RID: 23873
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
