using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.Relation
{
	// Token: 0x020002F0 RID: 752
	public class RelationshipCategory : Il2CppSystem.Object
	{
		// Token: 0x060038CC RID: 14540 RVA: 0x001291F8 File Offset: 0x001273F8
		// Note: this type is marked as 'beforefieldinit'.
		static RelationshipCategory()
		{
			Il2CppClassPointerStore<RelationshipCategory>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Relation", "RelationshipCategory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RelationshipCategory>.NativeClassPtr);
			RelationshipCategory.NativeFieldInfoPtr_Hostile_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationshipCategory>.NativeClassPtr, "Hostile_Color");
			RelationshipCategory.NativeFieldInfoPtr_Unfriendly_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationshipCategory>.NativeClassPtr, "Unfriendly_Color");
			RelationshipCategory.NativeFieldInfoPtr_Neutral_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationshipCategory>.NativeClassPtr, "Neutral_Color");
			RelationshipCategory.NativeFieldInfoPtr_Friendly_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationshipCategory>.NativeClassPtr, "Friendly_Color");
			RelationshipCategory.NativeFieldInfoPtr_Loyal_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationshipCategory>.NativeClassPtr, "Loyal_Color");
			RelationshipCategory.NativeMethodInfoPtr_GetCategory_Public_Static_ERelationshipCategory_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationshipCategory>.NativeClassPtr, 100669902);
			RelationshipCategory.NativeMethodInfoPtr_GetColor_Public_Static_Color32_ERelationshipCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationshipCategory>.NativeClassPtr, 100669903);
			RelationshipCategory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationshipCategory>.NativeClassPtr, 100669904);
		}

		// Token: 0x060038CD RID: 14541 RVA: 0x001292C8 File Offset: 0x001274C8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 141612, RefRangeEnd = 141615, XrefRangeStart = 141612, XrefRangeEnd = 141612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ERelationshipCategory GetCategory(float delta)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref delta;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationshipCategory.NativeMethodInfoPtr_GetCategory_Public_Static_ERelationshipCategory_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060038CE RID: 14542 RVA: 0x00129308 File Offset: 0x00127508
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 141623, RefRangeEnd = 141625, XrefRangeStart = 141615, XrefRangeEnd = 141623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Color32 GetColor(ERelationshipCategory category)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref category;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationshipCategory.NativeMethodInfoPtr_GetColor_Public_Static_Color32_ERelationshipCategory_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060038CF RID: 14543 RVA: 0x00129348 File Offset: 0x00127548
		[CallerCount(2259)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RelationshipCategory() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RelationshipCategory>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationshipCategory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038D0 RID: 14544 RVA: 0x0001D3C6 File Offset: 0x0001B5C6
		public RelationshipCategory(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001209 RID: 4617
		// (get) Token: 0x060038D1 RID: 14545 RVA: 0x00129384 File Offset: 0x00127584
		// (set) Token: 0x060038D2 RID: 14546 RVA: 0x0001D3CF File Offset: 0x0001B5CF
		public unsafe static Color32 Hostile_Color
		{
			get
			{
				Color32 result;
				IL2CPP.il2cpp_field_static_get_value(RelationshipCategory.NativeFieldInfoPtr_Hostile_Color, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RelationshipCategory.NativeFieldInfoPtr_Hostile_Color, (void*)(&value));
			}
		}

		// Token: 0x1700120A RID: 4618
		// (get) Token: 0x060038D3 RID: 14547 RVA: 0x001293A0 File Offset: 0x001275A0
		// (set) Token: 0x060038D4 RID: 14548 RVA: 0x0001D3DD File Offset: 0x0001B5DD
		public unsafe static Color32 Unfriendly_Color
		{
			get
			{
				Color32 result;
				IL2CPP.il2cpp_field_static_get_value(RelationshipCategory.NativeFieldInfoPtr_Unfriendly_Color, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RelationshipCategory.NativeFieldInfoPtr_Unfriendly_Color, (void*)(&value));
			}
		}

		// Token: 0x1700120B RID: 4619
		// (get) Token: 0x060038D5 RID: 14549 RVA: 0x001293BC File Offset: 0x001275BC
		// (set) Token: 0x060038D6 RID: 14550 RVA: 0x0001D3EB File Offset: 0x0001B5EB
		public unsafe static Color32 Neutral_Color
		{
			get
			{
				Color32 result;
				IL2CPP.il2cpp_field_static_get_value(RelationshipCategory.NativeFieldInfoPtr_Neutral_Color, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RelationshipCategory.NativeFieldInfoPtr_Neutral_Color, (void*)(&value));
			}
		}

		// Token: 0x1700120C RID: 4620
		// (get) Token: 0x060038D7 RID: 14551 RVA: 0x001293D8 File Offset: 0x001275D8
		// (set) Token: 0x060038D8 RID: 14552 RVA: 0x0001D3F9 File Offset: 0x0001B5F9
		public unsafe static Color32 Friendly_Color
		{
			get
			{
				Color32 result;
				IL2CPP.il2cpp_field_static_get_value(RelationshipCategory.NativeFieldInfoPtr_Friendly_Color, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RelationshipCategory.NativeFieldInfoPtr_Friendly_Color, (void*)(&value));
			}
		}

		// Token: 0x1700120D RID: 4621
		// (get) Token: 0x060038D9 RID: 14553 RVA: 0x001293F4 File Offset: 0x001275F4
		// (set) Token: 0x060038DA RID: 14554 RVA: 0x0001D407 File Offset: 0x0001B607
		public unsafe static Color32 Loyal_Color
		{
			get
			{
				Color32 result;
				IL2CPP.il2cpp_field_static_get_value(RelationshipCategory.NativeFieldInfoPtr_Loyal_Color, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RelationshipCategory.NativeFieldInfoPtr_Loyal_Color, (void*)(&value));
			}
		}

		// Token: 0x0400257E RID: 9598
		private static readonly IntPtr NativeFieldInfoPtr_Hostile_Color;

		// Token: 0x0400257F RID: 9599
		private static readonly IntPtr NativeFieldInfoPtr_Unfriendly_Color;

		// Token: 0x04002580 RID: 9600
		private static readonly IntPtr NativeFieldInfoPtr_Neutral_Color;

		// Token: 0x04002581 RID: 9601
		private static readonly IntPtr NativeFieldInfoPtr_Friendly_Color;

		// Token: 0x04002582 RID: 9602
		private static readonly IntPtr NativeFieldInfoPtr_Loyal_Color;

		// Token: 0x04002583 RID: 9603
		private static readonly IntPtr NativeMethodInfoPtr_GetCategory_Public_Static_ERelationshipCategory_Single_0;

		// Token: 0x04002584 RID: 9604
		private static readonly IntPtr NativeMethodInfoPtr_GetColor_Public_Static_Color32_ERelationshipCategory_0;

		// Token: 0x04002585 RID: 9605
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
